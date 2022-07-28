using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using ShapeBuilder;

public class ParameterSection : MonoBehaviour, Validator
{
    public ParameterField uField;
    public ParameterField vField;
    public ParameterField wField;

    public Button addButton;

    void Start() { }

    void Update() { }

    public ValidationResult ValidateInputs()
    {
        ValidationResult result;

        // Validate u field
        result = uField.ValidateInputs();
        if (result is not Success)
        {
            return result;
        }

        // Validate v field if active
        if (vField.gameObject.activeSelf)
        {
            result = vField.ValidateInputs();
            if (result is not Success)
            {
                return result;
            }
        }

        // Validate w field if active
        if (wField.gameObject.activeSelf)
        {
            return wField.ValidateInputs();
        }

        return result;
    }

    public void OnDeleteVFieldClick() => DisableField(vField);

    public void OnDeleteWFieldClick() => DisableField(wField);

    public void OnAddParameterClick()
    {
        // Enable v field if not enabled
        if (!vField.gameObject.activeSelf)
        {
            vField.gameObject.SetActive(true);
        }
        // Otherwise enable w field if not enabled
        else if (!wField.gameObject.activeSelf)
        {
            wField.gameObject.SetActive(true);
            if (vField.gameObject.activeSelf)
            {
                addButton.gameObject.SetActive(false);
            }
        }

        // Disable add parameter button if all field are enabled
        if (wField.gameObject.activeSelf && vField.gameObject.activeSelf)
        {
            addButton.gameObject.SetActive(false);
        }
    }

    public List<Parameter> GetParameters()
    {
        List<Parameter> parameters = new() { uField.GetParameter() };

        if (vField.gameObject.activeSelf)
        {
            parameters.Add(vField.GetParameter());
        }

        if (wField.gameObject.activeSelf)
        {
            parameters.Add(wField.GetParameter());
        }

        return parameters;
    }

    private void DisableField(ParameterField field)
    {
        field.gameObject.SetActive(false);
        addButton.gameObject.SetActive(true);
    }
}