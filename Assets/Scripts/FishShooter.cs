using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShooter : MonoBehaviour
{
    public GameObject bubblePrefab;   // Drag your bubble prefab here
    public Transform shootPoint;      // Empty GameObject at fish mouth
    public float bubbleSpeed = 8f;
    public float driftStrength = 2f;  // How much randomness in bubble direction

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Shoot when pressing Space
        {
            ShootBubble();
        }
    }

    void ShootBubble()
    {
        // Instantiate as child of shootPoint
        GameObject bubble = Instantiate(bubblePrefab, shootPoint.position, Quaternion.identity, shootPoint);

        Rigidbody rb = bubble.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Base forward direction
            Vector3 direction = shootPoint.forward;

            // Add some random drift
            Vector3 drift = new Vector3(
                Random.Range(-0.3f, 0.3f),
                Random.Range(-0.3f, 0.3f),
                0f
            );

            direction += drift * driftStrength;
            direction.Normalize();

            rb.velocity = direction * bubbleSpeed;
        }

        Destroy(bubble, 3f); // Destroy bubble after 3 seconds
    }
}
