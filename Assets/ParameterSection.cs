using UnityEngine;
using UnityEngine.EventSystems;

public class ParameterSection : MonoBehaviour, Validator
{
    public ParameterField uField;
    public ParameterField vField;
    public ParameterField wField;

    void Start()
    {

    }

    void Update()
    {

    }

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

    public void OnDeleteVFieldClick(BaseEventData _) => DisableField(vField);

    public void OnDeleteWFieldClick(BaseEventData _) => DisableField(wField);

    private void DisableField(ParameterField field) => field.gameObject.SetActive(false);
}