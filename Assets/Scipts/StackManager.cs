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
            collision.transform.gameObject.tag = "Collected";
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            gameObject.transform.tag = "Inactive";
        }
    }
}
