using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothingSpeed;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smootPosition = Vector3.Lerp(transform.position, desiredPosition, smoothingSpeed);
        transform.position = smootPosition;
    }
}
