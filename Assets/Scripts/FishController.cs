using UnityEngine;

public class FishController : MonoBehaviour
{
    public float swimSpeed = 5f;
    public float moveSpeed = 3f;

    void Update()
    {
        // Always move forward
        transform.Translate(Vector3.forward * swimSpeed * Time.deltaTime);

        // Get input
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Move sideways and up/down without rotating
        Vector3 move = new Vector3(horizontal, vertical, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(move);
    }
}
