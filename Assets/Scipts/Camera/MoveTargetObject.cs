using UnityEngine;

public class MoveTargetObject : MonoBehaviour
{
    [SerializeField] private float speed;
    public GameObject mainCube;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        speed = mainCube.GetComponent<Move>().speed;
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed * Time.fixedDeltaTime);
    }
}
