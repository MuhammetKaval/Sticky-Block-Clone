using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 35.0f;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(Vector3.forward * speed);
    }
}
