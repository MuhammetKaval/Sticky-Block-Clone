using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveSystem : MonoBehaviour
{

    [SerializeField] private float speed;

    private new Rigidbody rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (WallCollisionManager.Instance.onTheLeftSide || WallCollisionManager.Instance.onTheRightSide)
        {
            rigidbody.velocity = new Vector3(0, 0, rigidbody.velocity.z);
        }
    }


    private void FixedUpdate()
    {
        if (WallCollisionManager.Instance.onTheLeftSide && Input.GetKey(KeyCode.D))
        {
            //rigidbody.AddForce(Vector3.right * speed);
            rigidbody.velocity = new Vector3(speed, rigidbody.velocity.y, rigidbody.velocity.z);
        }

        else if (WallCollisionManager.Instance.onTheRightSide && Input.GetKey(KeyCode.A))
        {
            //rigidbody.AddForce(Vector3.left * speed);
            rigidbody.velocity = new Vector3(-speed, rigidbody.velocity.y, rigidbody.velocity.z);
        }
        else if (!WallCollisionManager.Instance.onTheLeftSide && !WallCollisionManager.Instance.onTheRightSide)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rigidbody.velocity = new Vector3(-speed, rigidbody.velocity.y, rigidbody.velocity.z);
                //rigidbody.AddForce(Vector3.left * speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                //rigidbody.AddForce(Vector3.right * speed);
                rigidbody.velocity = new Vector3(speed, rigidbody.velocity.y, rigidbody.velocity.z);
            }
        }
    }
}
