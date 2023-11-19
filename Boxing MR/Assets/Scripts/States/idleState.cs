using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleState : State
{
    public chaseState chasestate;
    public bool canSeeThePlayer;
    public override State RunCurrentState()
    {
        if (canSeeThePlayer)
        {
            return chasestate;
        }
        else
        {
            return this;
        }
   
    }
}
