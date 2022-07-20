using System.Collections.Generic;
using UnityEngine;

public class ParameterSection : MonoBehaviour, Validator
{
    public List<ParameterField> fields;

    void Start()
    {

    }

    void Update()
    {

    }

    public ValidationResult ValidateInputs()
    {
        ValidationResult result;
        foreach (Validator validator in fields)
        {
            result = validator.ValidateInputs();
            if (result is not Success)
            {
                return result;
            }
        }

        return new Success();
    }
}