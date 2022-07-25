public static class IntUtils
{
    public static void SaveToIntField(string strValue, ref int intField, int defaultValue)
    {
        if (string.IsNullOrEmpty(strValue) || !int.TryParse(strValue, out intField))
        {
            intField = defaultValue;
        }
    }
}
