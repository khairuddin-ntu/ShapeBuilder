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
        List<Vector3> vectors = await Task.Run(() => Calculate2dPoints(parameter));

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = vectors.Count;
        lineRenderer.SetPositions(vectors.ToArray());
    }

    private void Generate3dShape(List<Parameter> parameters)
    {
        Debug.Log($"{TAG}: GenerateShape: Should generate 3D shape");
    }

    private List<Vector3> Calculate2dPoints(Parameter parameter)
    {
        List<Vector3> vectors = new();

        for (float u = parameter.Min; u <= parameter.Max; u += 1f / resolution)
        {
            // TODO: Replace with equation from user input
            vectors.Add(new Vector3(
                (27 * u) - 9,
                Mathf.Cos(18 * Mathf.PI * u),
                0
            ));
        }

        return vectors;
    }
}
