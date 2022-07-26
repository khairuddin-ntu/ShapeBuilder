using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Jobs;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    private const string TAG = "ShapeGenerator";

    public ParameterSection paramSection;

    private int resolution = 100;

    private void Start() { }

    private void Update() { }

    public void GenerateShape()
    {
        Debug.Log($"{TAG}: GenerateShape: resolution = {resolution}");
        if (resolution <= 0)
        {
            return;
        }

        ValidationResult paramValidation = paramSection.ValidateInputs();
        if (paramValidation is not Success)
        {
            Debug.Log($"{TAG}: Parameter error = {(paramValidation as Error).ErrorMessage}");
            return;
        }

        List<Parameter> parameters = paramSection.GetParameters();
        if (parameters.Count == 1)
        {
            Generate2dShape(parameters[0]);
        }
        else
        {
            Generate3dShape(parameters);
        }
    }

    public void OnResolutionChange(string resFieldValue)
    {
        if (string.IsNullOrEmpty(resFieldValue) || !int.TryParse(resFieldValue, out resolution))
        {
            resolution = -1;
        }
    }

    private async void Generate2dShape(Parameter parameter)
    {
        List<Vector3> vectors = await Task.Run(() => PointCalculator.Calculate2dPoints(parameter, resolution));

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = vectors.Count;
        lineRenderer.SetPositions(vectors.ToArray());
    }

    private void Generate3dShape(List<Parameter> parameters)
    {
        Debug.Log($"{TAG}: GenerateShape: Should generate 3D shape");
    }
}
