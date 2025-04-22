using UnityEngine;

public class PlayerPawn : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tf;
    public float FMag;
    public float RotationSpeed;
    public CameraComponent CameraComponent;
    public float OffsetChangeRate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        CameraComponent = GetComponent<CameraComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward(){
        if(rb != null){
            rb.AddForce(tf.forward * FMag);
        }
    }
    public void MoveBackward(){
        if(rb != null){
            rb.AddForce(tf.forward * -FMag);
        }
    }
    public void Clockwise(){
        if(tf != null){
            tf.Rotate(new Vector3(0, 1, 0) * RotationSpeed * Time.deltaTime);
        }
    }
    public void CounterClockwise(){
        if(tf != null){
            tf.Rotate(new Vector3(0, 1, 0) * -RotationSpeed * Time.deltaTime);
        }
    }
    public void RollClock(){
        if(tf != null){
            tf.Rotate(new Vector3(0, 0, 1) * -RotationSpeed * Time.deltaTime);
        } 
    }
    public void RollCounter(){ 
        if(tf != null){
            tf.Rotate(new Vector3(0, 0, 1) * RotationSpeed * Time.deltaTime);
        }
    }
    public void PitchClock(){
        if(tf != null){
            tf.Rotate(new Vector3(1, 0, 0) * RotationSpeed * Time.deltaTime);
        }
    }
    public void PitchCounter(){
        if(tf != null){
            tf.Rotate(new Vector3(1, 0, 0) * -RotationSpeed * Time.deltaTime);
        }   
    }
    public void IncreaseCamOffset(){
        CameraComponent.ChangeCameraOffset(OffsetChangeRate);
    }
    public void DecreaseCamOffset(){
        CameraComponent.ChangeCameraOffset(-OffsetChangeRate);

    }

}
