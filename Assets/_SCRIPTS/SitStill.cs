using TMPro;
using UnityEngine;

public class SitStill : MonoBehaviour
{
    [SerializeField] TextMeshPro textMesh;

    Vector3 prevCameraRotation;

    void Start()
    {
        prevCameraRotation = Camera.main.transform.localEulerAngles;
    }

    void Update()
    {
        Vector3 currCameraRotation = Camera.main.transform.localEulerAngles;
        textMesh.text = Vector3.Distance(prevCameraRotation, currCameraRotation).ToString("F6");
        prevCameraRotation = currCameraRotation;
    }
}
