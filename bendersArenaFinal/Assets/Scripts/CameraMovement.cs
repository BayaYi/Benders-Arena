
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 0.2f;
    private Vector2 previousTouchPosition1;
    private Vector2 previousTouchPosition2;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
            {
                previousTouchPosition1 = touch1.position;
                previousTouchPosition2 = touch2.position;
            }
            else if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
            {
                Vector2 touchPosition1 = touch1.position;
                Vector2 touchPosition2 = touch2.position;

                Vector2 touchDelta1 = touchPosition1 - previousTouchPosition1;
                Vector2 touchDelta2 = touchPosition2 - previousTouchPosition2;

                float angleDelta = Vector2.Angle(touchDelta1, touchDelta2);

                if (Vector3.Cross(touchDelta1, touchDelta2).z < 0)
                {
                    angleDelta = -angleDelta;
                }

                transform.Rotate(Vector3.up, angleDelta * rotationSpeed);

                previousTouchPosition1 = touchPosition1;
                previousTouchPosition2 = touchPosition2;
            }
        }
    }
}