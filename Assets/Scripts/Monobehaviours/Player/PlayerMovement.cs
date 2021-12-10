using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovable
{
    [Header("Movement Variables")]
    public float gravity;
    public float speed;
    public float jumpHeight;

    [Header("Ground Check Variables")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask layerMask;

    [HideInInspector]
    public CharacterController characterController;

    Vector3 currentMovement;
    Vector3 nonGroundMovement;

    bool isGrounded;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector2 movementAxis)
    {
        currentMovement = (movementAxis.x * -transform.forward + movementAxis.y * transform.right) * speed;
    }

    public void Move(IMovable.MoveDirections moveDirections)
    {
        if(moveDirections == IMovable.MoveDirections.Jump)
        {
            if (isGrounded)
            {
                nonGroundMovement = transform.up * jumpHeight * 10;
            }
        }
    }

    public void Look(Vector2 lookVector)
    {
        throw new System.NotImplementedException();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, layerMask);

        if (isGrounded && nonGroundMovement.y < 0)
        {
            nonGroundMovement += -transform.up * 2;
        }
        else
        {
            nonGroundMovement += -transform.up * gravity * 100 * Time.deltaTime;
        }

        characterController.Move(currentMovement * Time.deltaTime);
        characterController.Move(nonGroundMovement * Time.deltaTime);
    }
}
