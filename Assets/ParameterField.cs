using UnityEngine;
using TMPro;

public class ParameterField : MonoBehaviour
{
    public TMP_Text paramLabel;

    public string paramName;

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
}
