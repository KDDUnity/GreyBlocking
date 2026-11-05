using UnityEngine;

public class PlayerCameraSync : MonoBehaviour
{
    [SerializeField]
    private Transform mainCameraTransform;

    void Start()
    {
        // Automatically grab the main camera's transform at the start
        if (Camera.main != null)
        {
            mainCameraTransform = Camera.main.transform;
        }
    }

    void Update()
    {
        if (mainCameraTransform == null) return;

        // 1. Get the direction the camera is looking
        Vector3 cameraForward = mainCameraTransform.forward;

        // 2. Flatten it on the Y axis so the player doesn't tilt up/down into the ground
        cameraForward.y = 0f;

        // 3. Make sure the vector is valid before rotating
        if (cameraForward.sqrMagnitude > 0.001f)
        {
            // 4. Create a rotation facing that direction and apply it to the player
            Quaternion targetRotation = Quaternion.LookRotation(cameraForward);
            transform.rotation = targetRotation;
        }
    }
}
