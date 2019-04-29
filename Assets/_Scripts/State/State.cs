using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour {
    public abstract void Tick();

    public virtual void OnStateEnter() {}
    public virtual void OnStateExit() {}

    protected Character character;
    public State(Character character) {
        this.character = character;
    }
}
