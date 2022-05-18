using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
    public Mesh sphere;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isReachFinishLine)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<SphereCollider>().enabled = true;

            gameObject.GetComponent<MeshFilter>().mesh = sphere;
            gameObject.GetComponent<Rigidbody>().freezeRotation = false;
        }
    }
}
