using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    private static float ROTATION_SPEED = 7.0f;
    private static float SCALE_SPEED = 0.7f;
    private static Vector3 MAX_SCALE = new Vector3(10f, 10f, 10f);
    private static Vector3 MIN_SCALE = new Vector3(1f, 1f, 1f);

    void Start() {}

    void Update() {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScroll != 0f) {
            float scale = mouseScroll * SCALE_SPEED;
            transform.localScale += new Vector3(scale, scale, scale);
            if (transform.localScale.x > MAX_SCALE.x) {
                transform.localScale = MAX_SCALE;
            } else if (transform.localScale.x < MIN_SCALE.x) {
                transform.localScale = MIN_SCALE;
            }
        }

    }

    public void OnMouseDrag() {
        float rotateX = Input.GetAxis("Mouse X") * ROTATION_SPEED;
		float rotateY = Input.GetAxis("Mouse Y") * ROTATION_SPEED;
        transform.Rotate(rotateY, -rotateX, 0.0f);
    }
}
