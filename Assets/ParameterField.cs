using UnityEngine;
using TMPro;

using ShapeBuilder;

public class ParameterField : MonoBehaviour, Validator
{
    public TMP_Text paramLabel;

    public string paramName;
    private int minValue = 0, maxValue = 1;

    void Start()
    {
        paramLabel.text = paramName;
    }

    void Update() { }

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

        // Check that min is not equal to max
        if (minValue == maxValue)
        {
            return new Error($"Parameter {paramName}: Minimum value [{minValue}] cannot be the same as maximum value [{maxValue}]");
        }

        // Check that min is less than max
        if (minValue > maxValue)
        {
            return new Error($"Parameter {paramName}: Minimum value [{minValue}] cannot be more than maximum value [{maxValue}]");
        }

        return new Success();
    }

    public Parameter GetParameter() => new(paramName, minValue, maxValue);
}
