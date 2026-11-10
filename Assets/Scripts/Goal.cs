using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            GameManager.instance.GameComplete();
            // Later you can load the next scene here
        }
    }
}
