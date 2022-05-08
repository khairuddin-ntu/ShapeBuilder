using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    private static float SENSITIVITY = 0.4f;

    private bool shouldRotate = false;
    private Vector3 prevMousePos;
    private Vector3 rotation = Vector3.zero;

    void Start() {}

    void Update() {
        if (!shouldRotate) return;

        Vector3 nextMousePos = Input.mousePosition;
        Vector3 mouseOffset = nextMousePos - prevMousePos;
        rotation.x = mouseOffset.y * SENSITIVITY;
        rotation.y = -(mouseOffset.x) * SENSITIVITY;
        transform.eulerAngles += rotation;
        prevMousePos = nextMousePos;
    }

    void OnMouseDown()
    {
        prevMousePos = Input.mousePosition;
        shouldRotate = true;
    }

    void OnMouseUp()
    {
        shouldRotate = false;
    }
}
