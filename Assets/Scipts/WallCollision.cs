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
            Debug.Log("on the left side: " + WallCollisionManager.Instance.onTheLeftSide);
        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            WallCollisionManager.Instance.onTheRightSide = true;
            Debug.Log("on the right side: " + WallCollisionManager.Instance.onTheRightSide);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LeftWall"))
        {
            WallCollisionManager.Instance.onTheLeftSide = false;
            Debug.Log("on the left side: " + WallCollisionManager.Instance.onTheLeftSide);
        }
        if (other.gameObject.CompareTag("RightWall"))
        {
            WallCollisionManager.Instance.onTheRightSide = false;
            Debug.Log("on the right side: " + WallCollisionManager.Instance.onTheRightSide);
        }
    }
}
