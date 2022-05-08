using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    private static float ROTATION_SPEED = 7.0f;

    void Start() {}

    void Update() {}

    public void OnMouseDrag() {
        float rotateX = Input.GetAxis("Mouse X") * ROTATION_SPEED;
		float rotateY = Input.GetAxis("Mouse Y") * ROTATION_SPEED;
        transform.Rotate(rotateY, -rotateX, 0.0f);
    }
}
