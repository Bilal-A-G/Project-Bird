using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic interface, used to add movement logic to an agent
public interface IMovable
{
    //Generic method that will move the agent based on movedirections
    void Move(MoveDirections moveDirections);

    //Enums for move direction, only should be used in player movement, "Any" should be used for entity movement
    enum MoveDirections
    {
        Left,
        Right,
        Forwards,
        Backwards,
        Jump,
        Any,
    }
}
