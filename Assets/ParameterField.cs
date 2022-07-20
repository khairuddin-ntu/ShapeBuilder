using UnityEngine;
using TMPro;

public class ParameterField : MonoBehaviour
{
    public TMP_Text paramLabel;

    public string paramName;
    private int minValue = 0, maxValue = 1;

    void Start()
    {
        if (paramName != null)
        {
            paramLabel.text = $"{paramName} = [";
        }
    }

    void Update() { }

    void SetParamName(string paramName)
    {
        this.paramName = paramName;
        paramLabel.text = $"{paramName} = [";
    }

    public void OnMinValueChange(string minFieldValue)
    {
        Debug.Log($"OnMinValueChange: Field value = {minFieldValue}");

        if (string.IsNullOrEmpty(minFieldValue) || !int.TryParse(minFieldValue, out minValue))
        {
            minValue = 0;
        }

        Debug.Log($"OnMinValueChange: Value changed to {minValue}");
    }

    public void OnMaxValueChange(string maxFieldValue)
    {
        Debug.Log($"OnMaxValueChange: Field value = {maxFieldValue}");

        if (string.IsNullOrEmpty(maxFieldValue) || !int.TryParse(maxFieldValue, out maxValue))
        {
            maxValue = 1;
        }

        Debug.Log($"OnMaxValueChange: Value changed to {maxValue}");
    }
}
