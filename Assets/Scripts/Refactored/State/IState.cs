using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void Enter(); // It is executed when we enter the first state.
    public void Update(); // Per-frame logic, include transition to a new state.
    public void Exit(); // It runs when we exit a state.
}
