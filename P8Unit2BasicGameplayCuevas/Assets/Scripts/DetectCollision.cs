using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Get Hit, Game Over");
        }
        else
            Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
