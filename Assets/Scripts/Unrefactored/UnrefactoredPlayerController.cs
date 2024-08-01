using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerControllerState{
    Idle,
    Walk,
    Jump
}

public class UnrefactoredPlayerController : MonoBehaviour
{
    private PlayerControllerState state;

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        switch(state)
        {
            case PlayerControllerState.Idle:
                Idle();
                break;
            case PlayerControllerState.Walk:
                Walk();
                break;
            case PlayerControllerState.Jump:
                Jump();
                break;
        }
    }

    private void GetInputs(){
        // Process the inputs in this case of Walk & Jump.   
    }
    private void Idle(){
        // logic of this action
    }
    private void Walk(){
        // logic of this action
    }
    private void Jump(){
        // logic of this action
    }
}
