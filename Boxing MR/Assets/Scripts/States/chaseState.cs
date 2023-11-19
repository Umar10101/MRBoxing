using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseState : State
{
    public attackState attackstate;
    public bool isInAttackRange;
    public override State RunCurrentState()
    {
        if (isInAttackRange)
        {
            return attackstate;
        }
        else
        {
            return this;
        }
    }
   
}
