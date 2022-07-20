using UnityEngine;
using TMPro;

public class ParameterField : MonoBehaviour, Validator
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
        IntUtils.SaveToIntField(minFieldValue, ref minValue, 0);
        Debug.Log($"OnMinValueChange: Value changed to {minValue}");
    }

    public void OnMaxValueChange(string maxFieldValue)
    {
        Debug.Log($"OnMaxValueChange: Field value = {maxFieldValue}");
        IntUtils.SaveToIntField(maxFieldValue, ref maxValue, 1);
        Debug.Log($"OnMaxValueChange: Value changed to {maxValue}");
    }

    public ValidationResult ValidateInputs()
    {
        // Check that min is less than max
        if (minValue >= maxValue)
        {
            return new Error($"Minimum value for parameter {paramName} cannot be the same or more than the maximum value");
        }

        return new Success();
    }
}
