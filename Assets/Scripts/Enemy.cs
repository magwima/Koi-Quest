using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveRange = 3f;
    public float speed = 2f;

    private Vector3 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        if (Vector3.Distance(startPos, transform.position) >= moveRange)
        {
            direction *= -1; // switch direction
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bubble"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            
            GameManager.instance.GameFail();
        }
    }
}



