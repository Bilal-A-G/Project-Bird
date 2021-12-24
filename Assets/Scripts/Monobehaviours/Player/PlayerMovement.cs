using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour, IMovable
{
    [Header("Movement Variables")]
    public float gravity;
    public float speed;
    public float jumpHeight;
    public float sprintSpeed;
    public float maxStamina;
    public float staminaDrain;
    public float staminaRegen;
    public int sprintingFov;
    public int walkingFov;
    public float zoomSpeed;

    [Header("Camera Variables")]
    public float mouseSensitivity;
    public Camera mainCamera;
    public bool invertedCamera;

    [Header("Ground Check Variables")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask layerMask;

    public TextMeshProUGUI staminaCount;

    [HideInInspector]
    public CharacterController characterController;

    Vector3 currentMovement;
    Vector3 currentJumpMovement;

    Vector2 currentMousePosition;
    float finalRotation;

    float currentSpeed;
    bool isSprinting;
    float currentStamina;

    bool isGrounded;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentSpeed = speed;
        currentStamina = maxStamina;
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
        if(moveDirections == IMovable.MoveDirections.Sprint)
        {
            isSprinting = !isSprinting;
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

        staminaCount.text = "Stamina: " + ((int)currentStamina);

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



        Vector3 finalMovement = (currentMovement.x * transform.right + currentMovement.y * transform.forward) * currentSpeed;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, layerMask);

        ControlStamina();
        CalculateCurrentJumpMovement();

        characterController.Move(finalMovement * Time.deltaTime);
        characterController.Move(currentJumpMovement * Time.deltaTime);
    }

    void CalculateCurrentJumpMovement()
    {
        if (isGrounded && currentJumpMovement.y < 0)
        {
            currentJumpMovement = -transform.up;
        }
        else
        {
            currentJumpMovement += -transform.up * gravity * 100 * Time.deltaTime;
        }
    }

    void ControlStamina()
    {
        float currentFov = walkingFov;

        if (isSprinting && isGrounded && currentStamina > 0)
        {
            currentStamina -= staminaDrain * Time.deltaTime;

            if (currentStamina < 0)
            {
                currentStamina = 0;
            }
        }

        if (!isSprinting && isGrounded && currentStamina < maxStamina)
        {
            currentStamina += staminaRegen * Time.deltaTime;

            if (currentStamina > maxStamina)
            {
                currentStamina = maxStamina;
            }
        }

        if (isSprinting && currentStamina > 0)
        {
            currentSpeed = sprintSpeed;
            currentFov = Mathf.Lerp(mainCamera.fieldOfView, sprintingFov, Time.deltaTime * zoomSpeed);
        }
        else
        {
            currentSpeed = speed;
            currentFov = Mathf.Lerp(mainCamera.fieldOfView, walkingFov, Time.deltaTime * zoomSpeed);
        }

        mainCamera.fieldOfView = currentFov;
    }
}
