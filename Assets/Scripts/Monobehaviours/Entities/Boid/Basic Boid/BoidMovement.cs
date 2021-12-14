using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidMovement : MonoBehaviour, IMovable
{
    public void Look(Vector2 lookVector)
    {
        throw new System.NotImplementedException();
    }

    public void Move(IMovable.MoveDirections moveDirections)
    {
        if(moveDirections == IMovable.MoveDirections.Any)
        {

        }
    }

    public void Move(Vector2 moveAxis) => throw new System.NotImplementedException();

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
