using TMPro;
using UnityEngine;

public class SitStill : MonoBehaviour
{
    [SerializeField] TextMeshPro textMesh;
    [SerializeField] Material skyboxOriginal;

    Vector3 prevCameraPosition;
    Material skyboxCopy;
    float cameraPositionDiff;

    void Awake()
    {
        skyboxCopy = new Material(RenderSettings.skybox);
        RenderSettings.skybox = skyboxCopy;
    }

    void Start()
    {
        prevCameraPosition = Camera.main.transform.localPosition;
    }

    void Update()
    {
        Vector3 currCameraPosition = Camera.main.transform.localPosition;
        cameraPositionDiff = Vector3.Distance(prevCameraPosition, currCameraPosition);
        prevCameraPosition = currCameraPosition;

        textMesh.text = cameraPositionDiff.ToString("F6");
        skyboxCopy.SetFloat("_Exposure", Mathf.Clamp01(1000 * cameraPositionDiff));
    }
}
