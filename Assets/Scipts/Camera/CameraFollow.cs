using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -10);

    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
