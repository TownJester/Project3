using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerPawn pawn;
    public KeyCode MoveForward;
    public KeyCode MoveBackward;
    public KeyCode Clockwise;
    public KeyCode CounterClockwise;
    public KeyCode RollClock;
    public KeyCode RollCounter;
    public KeyCode PitchClock;
    public KeyCode PitchCounter;
    public KeyCode IncreaseCamOffset;
    public KeyCode DecreaseCamOffset;

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
        if (Input.GetKey(MoveForward)){
            pawn.MoveForward();
        }
        if (Input.GetKey(MoveBackward)){
            pawn.MoveBackward();
        }
        if (Input.GetKey(Clockwise)){
            pawn.Clockwise();
        }
        if (Input.GetKey(CounterClockwise)){
            pawn.CounterClockwise();
        }
        if (Input.GetKey(RollClock)){
            pawn.RollClock();
        }
        if (Input.GetKey(RollCounter)){
            pawn.RollCounter();
        }
        if (Input.GetKey(PitchClock)){
            pawn.PitchClock();
        }
        if (Input.GetKey(PitchCounter)){
            pawn.PitchCounter();
        }
        if (Input.GetKey(IncreaseCamOffset)){
            pawn.IncreaseCamOffset();
        }
        if (Input.GetKey(DecreaseCamOffset)){
            pawn.DecreaseCamOffset();
        }
    }
}
