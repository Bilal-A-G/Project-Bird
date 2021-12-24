using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    InputActions inputActions;
    IMovable movementLogic;
    IKillable deathLogic;
    IInteractable interactLogic;

    public TextMeshProUGUI healthCount;

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        movementLogic = GetComponent<IMovable>();
        deathLogic = GetComponent<IKillable>();
        interactLogic = GetComponent<IInteractable>();

        inputActions = new InputActions();

        inputActions.PC.Movement.performed += ctx => movementLogic.Move(ctx.ReadValue<Vector2>());
        inputActions.PC.Sprint.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Sprint);
        inputActions.PC.Jump.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Jump);

        inputActions.PC.MouseMovement.performed += ctx => { movementLogic.Look(ctx.ReadValue<Vector2>()); interactLogic.HoverOver(GetMousePointingObject()); };
        inputActions.PC.Interact.performed += ctx => interactLogic.Interact(GetMousePointingObject());
    }

    GameObject GetMousePointingObject()
    {
        RaycastHit raycastResults;

        GameObject returnObject;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastResults))
        {
            returnObject = raycastResults.collider.gameObject;
        }
        else
        {
            returnObject = null;
        }

        return returnObject;
    }

    private void Update()
    {
        if(deathLogic.GetCurrentHealth() <= 0)
        {
            deathLogic.Die();
            Cursor.lockState = CursorLockMode.None;
        }
        healthCount.text = ("Health: " + deathLogic.GetCurrentHealth().ToString());
    }
}
