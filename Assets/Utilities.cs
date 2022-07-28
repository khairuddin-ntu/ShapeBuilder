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

    public static class DoubleUtils
    {
        public static double ParseString(string strValue, double defaultValue = -1)
        {
            if (double.TryParse(strValue, out double result))
            {
                result = defaultValue;
            }

            return result;
        }
    }
}
