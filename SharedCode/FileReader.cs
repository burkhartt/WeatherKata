using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SharedCode
{
    public class FileReader
    {
        public IEnumerable<T> Read<T>(string filePath) where T : ConvertibleDataType, new()
        {
            var cellParser = new CellParser();

            var lines = File.ReadAllLines(filePath);
            var typedLines = lines.Select(line => line.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)).Select(cells => cells.Select(cell => cellParser.Parse(cell)).ToArray());
            var list = new List<T>();

            foreach (var typedLine in typedLines)
            {
                var t = new T();
                var mappings = t.GetMappings();
                foreach (var mapping in mappings)
                {
                    t.GetType().GetProperty(mapping.Value).SetValue(t, typedLine[mapping.Key], null);
                }
                list.Add(t);
            }
            return list;
        }
    }
}