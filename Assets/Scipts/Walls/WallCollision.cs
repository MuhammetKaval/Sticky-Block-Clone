using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            WallCollisionManager.Instance.onTheLeftSide = true;
        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            WallCollisionManager.Instance.onTheRightSide = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            WallCollisionManager.Instance.onTheLeftSide = false;
        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            WallCollisionManager.Instance.onTheRightSide = false;
        }
    }
}
