using UnityEngine;

public class GraphController : MonoBehaviour
{
    private const float ROTATION_SPEED = 7.0f;
    private const float SCALE_SPEED = 0.7f;
    private const float MAX_SCALE = 10f;
    private const float MIN_SCALE = 1f;

    public Transform graphTransform;

    void Update()
    {
        float mouseScroll = Input.GetAxis("Mouse ScrollWheel");
        if (mouseScroll == 0f) return;

        float scale = graphTransform.localScale.x + (mouseScroll * SCALE_SPEED);
        if (scale > MAX_SCALE)
        {
            scale = MAX_SCALE;
        }
        else if (scale < MIN_SCALE)
        {
            scale = MIN_SCALE;
        }

        graphTransform.localScale = new Vector3(scale, scale, scale);

    }

    public void OnMouseDrag()
    {
        float rotateX = Input.GetAxis("Mouse X") * ROTATION_SPEED;
        float rotateY = Input.GetAxis("Mouse Y") * ROTATION_SPEED;
        graphTransform.Rotate(rotateY, -rotateX, 0.0f);
    }
}
