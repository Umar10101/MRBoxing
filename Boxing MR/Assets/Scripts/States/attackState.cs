using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackState : State
{
    public override State RunCurrentState()
    {
        Debug.Log("i have attacked");
        return this;
    }
}
