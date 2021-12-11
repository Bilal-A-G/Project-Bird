using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovable
{
    [Header("Movement Variables")]
    public float gravity;
    public float speed;
    public float jumpHeight;

    [Header("Camera Variables")]
    public float mouseSensitivity;
    public Camera mainCamera;
    public bool invertedCamera;

    [Header("Ground Check Variables")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask layerMask;

    [HideInInspector]
    public CharacterController characterController;

    Vector3 currentMovement;
    Vector3 currentJumpMovement;

    Vector2 currentMousePosition;
    float finalRotation;

    bool isGrounded;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Move(Vector2 movementAxis)
    {
        currentMovement = movementAxis;
    }

    public void Move(IMovable.MoveDirections moveDirections)
    {
        if(moveDirections == IMovable.MoveDirections.Jump)
        {
            if (isGrounded)
            {
                currentJumpMovement = transform.up * jumpHeight * 10;
            }
        }
    }

    public void Look(Vector2 lookVector)
    {
        if(lookVector != Vector2.zero)
        {
            currentMousePosition += lookVector;
        }
        else
        {
            currentMousePosition = Vector2.zero;
        }
    }

    void Update()
    {
        float xRotation, yRotation;
        
        xRotation = transform.localEulerAngles.y + currentMousePosition.x * mouseSensitivity * 0.25f;
        yRotation = currentMousePosition.y * mouseSensitivity * 0.25f;

        if (!invertedCamera)
        {
            finalRotation -= yRotation;
        }
        else
        {
            finalRotation += yRotation;
        }

        finalRotation = Mathf.Clamp(finalRotation, -90, 90);

        transform.localEulerAngles = new Vector3(0, xRotation, 0);
        mainCamera.transform.localEulerAngles = new Vector3(finalRotation, 0, 0);



        Vector3 finalMovement = (currentMovement.x * transform.right + currentMovement.y * transform.forward) * speed;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, layerMask);

        if (isGrounded && currentJumpMovement.y < 0)
        {
            currentJumpMovement += -transform.up * 2;
        }
        else
        {
            currentJumpMovement += -transform.up * gravity * 100 * Time.deltaTime;
        }

        characterController.Move(finalMovement * Time.deltaTime);
        characterController.Move(currentJumpMovement * Time.deltaTime);
    }
}
