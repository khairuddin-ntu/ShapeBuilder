using UnityEngine;
using UnityEngine.UI;

public class ShapeGenerator : MonoBehaviour
{
    private const string TAG = "ShapeGenerator";

    public Slider slider;

    private void Start() { }

    private void Update() { }

    public void GenerateShape()
    {
        Debug.Log($"{TAG}: GenerateShape: Slider value = {slider.value}");
    }
}
