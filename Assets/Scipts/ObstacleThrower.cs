using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleThrower : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable") || collision.gameObject.CompareTag("Obstacle"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
