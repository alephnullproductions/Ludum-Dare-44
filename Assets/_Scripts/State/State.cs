using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State {
    public abstract int Tick(int wait);

    public virtual void OnStateEnter() {}
    public virtual void OnStateExit() {}

    protected Character character;
    public State(Character character) {
        this.character = character;
    }
}
