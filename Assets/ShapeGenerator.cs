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
        Debug.Log($"{TAG}: GenerateShape: Slider value = {slider.value}");
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
        Debug.Log($"{TAG}: GenerateShape: Should generate 2D shape");
    }

    private void Generate3dShape()
    {
        Debug.Log($"{TAG}: GenerateShape: Should generate 3D shape");
    }
}
