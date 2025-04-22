using UnityEngine;

public class AIPawn : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float force;
    public Transform tf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveRigidBody(Vector3 direction){
        rb.AddForce(direction * force);
    }
    public void MoveTransform(Vector3 direction){
        tf.position += direction * speed * Time.deltaTime;

    }
}
