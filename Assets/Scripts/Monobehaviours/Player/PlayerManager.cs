using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputActions inputActions;
    IMovable movementLogic;
    IKillable deathLogic;
    IAttackable attackLogic;

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
        movementLogic = GetComponent<IMovable>();
        attackLogic = GetComponent<IAttackable>();
        deathLogic = GetComponent<IKillable>();

        inputActions = new InputActions();
        inputActions.PC.Forwards.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Forwards);
        inputActions.PC.Backwards.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Backwards);
        inputActions.PC.Left.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Left);
        inputActions.PC.Right.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Right);
        inputActions.PC.Jump.performed += ctx => movementLogic.Move(IMovable.MoveDirections.Jump);
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
