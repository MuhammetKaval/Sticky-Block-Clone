using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed;

    void LateUpdate()
    {
        Vector3 desiredPos = new Vector3(transform.position.x, target.transform.position.y, target.transform.position.z) + (offset);
        transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
    }
}
