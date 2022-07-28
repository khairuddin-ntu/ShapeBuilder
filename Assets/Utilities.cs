namespace ShapeBuilder
{
    public static class IntUtils
    {
        public static void SaveToIntField(string strValue, ref int intField, int defaultValue)
        {
            if (string.IsNullOrEmpty(strValue) || !int.TryParse(strValue, out intField))
            {
                intField = defaultValue;
            }
        }

        public static int ParseString(string strValue, int defaultValue = -1)
        {
            if (int.TryParse(strValue, out int result))
            {
                result = defaultValue;
            }

            return result;
        }
    }
}
