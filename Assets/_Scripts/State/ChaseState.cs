using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public ChaseState(Character character) : base(character) {}

    
    
    public override int Tick(int wait) {
        return 0;
    }
}
