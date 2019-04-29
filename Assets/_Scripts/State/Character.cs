using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour {

    [SerializeField]
    public Destinations scriptableDest;

    public NavMeshAgent nav;

    public List<GameObject> destinations;
    public List<Vector3> Vector3s;
    
    [SerializeField]
    public State currentState;
    public float moveSpeed;

    private void Awake() {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        foreach (GameObject go in scriptableDest.places)
        {
            destinations.Add(go);
        }

        foreach (Vector3 v3 in scriptableDest.Vector3s) {
            Vector3s.Add(v3);
        }

        currentState = new PatrolState(this, Vector3s[0], Vector3s, 0);
//        SetState(new ReturnHomeState(this));
    }

    private void Update()
    {
        currentState.Tick(5000);
    }

    public void MoveToward(Vector3 destination) {
        nav.SetDestination (destination);
//        var direction = GetDirection(destination);
//        transform.Translate(direction * Time.deltaTime * moveSpeed);
//            transform.Translate(direction);
    }

    private Vector3 GetDirection(Vector3 destination) {
        return (destination - transform.position).normalized;
    }

    public void SetState(State state)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }
        currentState = state;
//        gameObject.name = "Cube -" + state.GetType().Name;

        if (currentState != null)
        {
            currentState.OnStateEnter();
        }
    }
    
}
