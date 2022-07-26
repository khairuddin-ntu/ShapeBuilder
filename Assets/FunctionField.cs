using UnityEngine;
using TMPro;

public class FunctionField : MonoBehaviour
{
    public TMP_Text nameLabel;

    public string functionName;

    void Start()
    {
        nameLabel.text = functionName;
    }

    void Update() { }
}
