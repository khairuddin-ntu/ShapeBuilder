using UnityEngine;
using TMPro;

public class FunctionField : MonoBehaviour
{
    private const string TAG = "FunctionField";

    public TMP_Text nameLabel;
    public string functionName;

    private string functionInput = "";

    void Start()
    {
        nameLabel.text = functionName;
    }

    void Update() { }

    public void OnEndFunctionEdit(string functionInput)
    {
        Debug.Log($"{TAG}: ++OnFunctionEditEnd++  {functionName} = {functionInput}");
        this.functionInput = functionInput;
    }
}
