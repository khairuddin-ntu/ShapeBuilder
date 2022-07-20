using UnityEngine;
using TMPro;

public class ParameterField : MonoBehaviour
{
    public TMP_Text paramLabel;

    public string paramName;

    void Start()
    {
        paramLabel.text = $"{paramName} = [";
    }

    void Update()
    {
        
    }
}
