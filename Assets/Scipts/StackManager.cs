using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            collision.gameObject.GetComponent<Move>().enabled = true;
            collision.gameObject.GetComponent<SwerveSystem>().enabled = true;
            collision.gameObject.GetComponent<WallCollision>().enabled = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
        }
    }
}
