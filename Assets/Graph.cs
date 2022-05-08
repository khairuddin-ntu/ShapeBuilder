using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    private static float ROTATION_SPEED = 0.2f;

    void Start() {}

    void Update() {}

    public void OnMouseDrag() {
        float rotateX = Input.GetAxis("Mouse X") * ROTATION_SPEED;
		float rotateY = Input.GetAxis("Mouse Y") * ROTATION_SPEED;
		transform.RotateAround(Vector3.down, rotateX);
		transform.RotateAround(Vector3.right, rotateY);
    }
}
