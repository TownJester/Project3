using UnityEngine;

public class CameraComponent : MonoBehaviour
{
    public Transform CameraTransform;
    public Transform TargetTransform;
    public float MinOffset;
    public float MaxOffset;
    public float CurrentOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 MovePosition = TargetTransform.position - CameraTransform.position;
        CurrentOffset = MinOffset;
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransform.LookAt(TargetTransform);
    }
    public void ChangeCameraOffset(float amount){
        CurrentOffset += amount * Time.deltaTime;
        CurrentOffset = Mathf.Clamp(CurrentOffset, MinOffset, MaxOffset);
    }
}
