using UnityEngine;

public class GraphController : MonoBehaviour
{
    private const float ROTATION_SPEED = 7.0f;
    private const float SCALE_SPEED = 0.7f;
    private static readonly Vector3 MAX_SCALE = new Vector3(10f, 10f, 10f);
    private static readonly Vector3 MIN_SCALE = new Vector3(1f, 1f, 1f);

    public Transform graphTransform;

    void Start() {}

    void Update() {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScroll != 0f) {
            float scale = mouseScroll * SCALE_SPEED;
            graphTransform.localScale += new Vector3(scale, scale, scale);
            if (graphTransform.localScale.x > MAX_SCALE.x) {
                graphTransform.localScale = MAX_SCALE;
            } else if (graphTransform.localScale.x < MIN_SCALE.x) {
                graphTransform.localScale = MIN_SCALE;
            }
        }

    }

    public void OnMouseDrag() {
        float rotateX = Input.GetAxis("Mouse X") * ROTATION_SPEED;
		float rotateY = Input.GetAxis("Mouse Y") * ROTATION_SPEED;
        graphTransform.Rotate(rotateY, -rotateX, 0.0f);
    }
}
