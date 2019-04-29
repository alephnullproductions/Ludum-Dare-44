using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State {
    private Vector3 curDestination;
    public List<Vector3> destinations;
    private int index;

    public PatrolState(Character character, Vector3 curDestination, List<Vector3> destinations, int index) : base(character) {
        this.curDestination = curDestination;
        this.destinations = destinations;
        this.index = index;
    }

    // int is the wait period of a Coroutine...
    public override int Tick(int waitTime) {
        character.MoveToward(curDestination);
        
        Debug.Log(curDestination);

        if (!ReachedDestination()) return 1;
        index = (index + 1) % destinations.Count;

        curDestination = destinations[index];

        return waitTime;
//        yield return new WaitForSeconds(5);
//        character.SetState(new PatrolState(character, curDestination, destinations, index));
    }

    // This distance will depend, for Zones it should be < 0.5f
    //    for Chasing, it should be < 2.0f (because of the radius of characters)
    //        May want to use a Collider based solution for our Tag based gameplay...
    private bool ReachedDestination() {
        return Vector3.Distance(character.transform.position, curDestination) < 0.5f;
    }
    
    
    
}
