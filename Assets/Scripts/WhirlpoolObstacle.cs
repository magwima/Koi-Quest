using UnityEngine;

public class WhirlpoolObstacle : MonoBehaviour
{
    public float pullForce = 5f;
    public float radius = 5f;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 direction = transform.position - other.transform.position;
            float distance = direction.magnitude;

            if (distance < radius)
            {
                // Pull player towards center
                other.transform.position += direction.normalized * pullForce * Time.deltaTime;
                Debug.Log("Game Over, tornado");
                GameManager.instance.GameFail();
            }
        }
    }
}
