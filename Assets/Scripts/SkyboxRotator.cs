using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    [Tooltip("Rotation speed in degrees per second")]
    public float rotationSpeed = 1.0f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
        DynamicGI.UpdateEnvironment(); // updates lighting if needed
    }
}
