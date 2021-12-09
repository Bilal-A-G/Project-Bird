using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovable
{
    public float gravity;
    public float speed;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask layerMask;

    public CharacterController characterController;

    bool isMovingLeft;
    bool isMovingRight;
    bool isMovingForwards;
    bool isMovingBackwards;

    bool isGrounded;


    public void Move(IMovable.MoveDirections moveDirections)
    {
        if(moveDirections == IMovable.MoveDirections.Left)
        {
            isMovingLeft = !isMovingLeft;
        }
        if(moveDirections == IMovable.MoveDirections.Right)
        {
            isMovingRight = !isMovingRight;
        }
        if(moveDirections == IMovable.MoveDirections.Forwards)
        {
            isMovingForwards = !isMovingForwards;
        }
        if(moveDirections == IMovable.MoveDirections.Backwards)
        {
            isMovingBackwards = !isMovingBackwards;
        }
        if(moveDirections == IMovable.MoveDirections.Jump)
        {

        }
    }

    void Update()
    {
        characterController.Move(Vector3.down * gravity * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, layerMask);

        if(isMovingLeft || isMovingRight || isMovingForwards || isMovingBackwards)
        {
            Debug.Log("Moving");
        }
    }
}
