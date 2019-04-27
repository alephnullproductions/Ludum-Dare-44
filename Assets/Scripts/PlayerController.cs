using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float runSpeed;

    public KeyCode upButton;
    public KeyCode rightButton;
    public KeyCode downButton;
    public KeyCode leftButton;
    public KeyCode runButton;

    internal bool isWalking;
    internal bool isRunning;

    internal Directions facingDirection;          // used to determine which animation to play

    void Start()
    {

    }

    void Update()
    {
    }

    void FixedUpdate()
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
        if (Input.GetKey(runButton))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
        var direction = Vector3.zero;
        if (Input.GetKey(upButton))
        {
            direction += Vector3.forward;
            if (
                !(Input.GetKey(downButton)
                || Input.GetKey(leftButton)
                || Input.GetKey(rightButton))
             )
            {
                facingDirection = Directions.Up;
            }
        }
        if (Input.GetKey(rightButton))
        {
            direction += Vector3.right;
            if (
                !(Input.GetKey(upButton)
                || Input.GetKey(leftButton)
                || Input.GetKey(downButton))
             )
            {
                facingDirection = Directions.Right;
            }
        }
        if (Input.GetKey(downButton))
        {
            direction += Vector3.back;
            if (
                !(Input.GetKey(upButton)
                || Input.GetKey(leftButton)
                || Input.GetKey(rightButton))
             )
            {
                facingDirection = Directions.Down;
            }
        }
        if (Input.GetKey(leftButton))
        {
            direction += Vector3.left;
            if (
                !(Input.GetKey(upButton)
                || Input.GetKey(downButton)
                || Input.GetKey(rightButton))
             )
            {
                facingDirection = Directions.Left;
            }
        }

        isWalking = direction.magnitude > 0;
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(direction * (isRunning ? runSpeed : speed), ForceMode.Impulse);
    }

}
