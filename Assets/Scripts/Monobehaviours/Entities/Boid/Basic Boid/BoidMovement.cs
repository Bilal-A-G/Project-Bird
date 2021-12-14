using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidMovement : MonoBehaviour, IMovable
{
    public GameObject player;
    public float speed;

    CharacterController characterController;

    public float boidDistance;
    public float detectionDistance;

    Vector3 step;

    public void Move(IMovable.MoveDirections moveDirections)
    {
        if(moveDirections == IMovable.MoveDirections.Any)
        {
            if(player != null && (player.transform.position - transform.position).magnitude <= detectionDistance)
            {
                step = (player.transform.position - transform.position).normalized * speed * Time.deltaTime;
            }
            else
            {
                step = Vector3.zero;
            }

            characterController.Move(new Vector3(step.x, -9.8f, step.z));
        }
    }

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {

    }

    public void Look(Vector2 lookVector) => throw new System.NotImplementedException();
    public void Move(Vector2 moveAxis) => throw new System.NotImplementedException();
}
