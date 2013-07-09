using System.Collections.Generic;

namespace SharedCode
{
    public abstract class ConvertibleDataType
    {
        public abstract IDictionary<int, string> GetMappings();    
    }
}