using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isWalking;

    internal Directions facingDirection;          // used to determine which animation to play

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        HandleActionKeys();
        HandleMovement();
    }

    private void HandleActionKeys()
    {
        // TODO
    }

    private void HandleMovement()
    {        
        var direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
            if (
                !(Input.GetKey(KeyCode.S)
                || Input.GetKey(KeyCode.A)
                || Input.GetKey(KeyCode.D))
             )
            {
                facingDirection = Directions.Up;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
            if (
                !(Input.GetKey(KeyCode.W)
                || Input.GetKey(KeyCode.A)
                || Input.GetKey(KeyCode.S))
             )
            {
                facingDirection = Directions.Right;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
            if (
                !(Input.GetKey(KeyCode.W)
                || Input.GetKey(KeyCode.A)
                || Input.GetKey(KeyCode.D))
             )
            {
                facingDirection = Directions.Down;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
            if (
                !(Input.GetKey(KeyCode.W)
                || Input.GetKey(KeyCode.S)
                || Input.GetKey(KeyCode.D))
             )
            {
                facingDirection = Directions.Left;
            }
        }

        isWalking = direction.magnitude > 0;
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
