using UnityEngine;

public class InvertCameraRotation : MonoBehaviour
{
    [SerializeField] bool InvertX;
    [SerializeField] bool InvertY;
    [SerializeField] bool InvertZ;

    Transform cameraTransform;
    Transform cameraParentTransform;
    Vector3 prevEulerAngles;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        cameraParentTransform = cameraTransform.parent;
        prevEulerAngles = cameraTransform.localEulerAngles;
    }

    void Update()
    {
        Vector3 eulerAngleDiff = cameraTransform.localEulerAngles - prevEulerAngles;
        if (!InvertX)
        {
            eulerAngleDiff.x = 0;
        }
        if (!InvertY)
        {
            eulerAngleDiff.y = 0;
        }
        if (!InvertZ)

        {
            eulerAngleDiff.z = 0;
        }
        cameraParentTransform.eulerAngles -= 2 * eulerAngleDiff;
        prevEulerAngles = cameraTransform.localEulerAngles;
    }
}
