namespace SharedCode
{
    public class CellParser
    {
        public dynamic Parse(string cell)
        {
            cell = cell.Replace("*", "");
            int tempInt;
            if (int.TryParse(cell.Trim(), out tempInt))
            {
                return tempInt;
            }
            return cell.Trim();
        }
    }
}