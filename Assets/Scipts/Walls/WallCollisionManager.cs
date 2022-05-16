using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisionManager : MonoBehaviour
{
    public static WallCollisionManager Instance;

    public bool onTheLeftSide;
    public bool onTheRightSide;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
}
