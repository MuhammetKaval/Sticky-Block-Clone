using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed = 35.0f;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed * Time.fixedDeltaTime);
    }
}
