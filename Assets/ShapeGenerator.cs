using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeGenerator : MonoBehaviour
{
    private const string TAG = "ShapeGenerator";
    private const int SLIDER_2D_VALUE = 0;
    private const int SLIDER_3D_VALUE = 1;

    public Slider slider;

    private void Start() { }

    private void Update() { }

    public void GenerateShape()
    {
        switch (slider.value)
        {
            case SLIDER_2D_VALUE:
                Generate2dShape();
                break;
            case SLIDER_3D_VALUE:
                Generate3dShape();
                break;
        }
    }

    private void Generate2dShape()
    {
        // TODO: Replace with equation from user input and run in another thread
        List<Vector3> vectors = new();
        for (float u = 0; u <= 1; u += 1f / 100)
        {
            vectors.Add(new Vector3(
                (27 * u) - 9,
                Mathf.Cos(18 * Mathf.PI * u),
                0
            ));
        }

        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        Debug.Log($"{TAG}: Generate2dShape: Is lineRenderer null? {lineRenderer == null}");
        lineRenderer.positionCount = vectors.Count;
        lineRenderer.SetPositions(vectors.ToArray());
    }

    private void Generate3dShape()
    {
        Debug.Log($"{TAG}: GenerateShape: Should generate 3D shape");
    }
}
