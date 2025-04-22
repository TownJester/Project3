using UnityEngine;

public class AIController : MonoBehaviour
{
    public AIPawn pawn; 
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    public void ProcessInputs(){
        MoveRigidBody();
        MoveTransform();
    }

    public void MoveRigidBody(){
        Vector3 directionToTarget = target.position - pawn.transform.position;
        directionToTarget = directionToTarget.normalized;
        pawn.MoveRigidBody(directionToTarget);
    }
    public void MoveTransform(){
    Vector3 directionToTarget = target.position - pawn.transform.position;
    directionToTarget = directionToTarget.normalized;
    pawn.MoveTransform(directionToTarget);

    }
}