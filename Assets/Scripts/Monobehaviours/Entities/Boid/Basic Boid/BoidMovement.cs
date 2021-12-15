using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidMovement : MonoBehaviour, IMovable
{
    public GameObject player;
    public float speed;
    public float rotateSpeed;

    CharacterController characterController;

    public float collisionDistance;
    public float boidDistance;
    public float detectionDistance;

    public float collisionCheckInterval;
    bool isAvoidingObstacle;

    Vector3 step;

    public void Move(IMovable.MoveDirections moveDirections)
    {
        for (float i = 0; i < 180; i += collisionCheckInterval)
        {
            float angleInRadians = i * Mathf.PI / 180;
            float angleBetweenObstacleAndBoid;

            isAvoidingObstacle = false;

            Vector3 topRow = new Vector3(Mathf.Cos(angleInRadians), 0, Mathf.Sin(angleInRadians));
            Vector3 middleRow = new Vector3(0, 1, 0);
            Vector3 lastRow = new Vector3(-Mathf.Sin(angleInRadians), 0, Mathf.Cos(angleInRadians));

            Matrix rotationMatrix = new Matrix(topRow, middleRow, lastRow);

            Vector3 raycastDirection = Multiply(rotationMatrix, -transform.right.normalized);
            
            RaycastHit hit;

            Debug.DrawRay(transform.position, raycastDirection);

            if (Physics.Raycast(transform.position, raycastDirection, out hit))
            {
                if((hit.transform.position - transform.position).magnitude <= collisionDistance && hit.transform.tag != "Player" && hit.transform.tag != "Boid" || (hit.transform.position - transform.position).magnitude <= boidDistance && hit.transform.tag == "Boid")
                {
                    angleBetweenObstacleAndBoid = Mathf.Acos(Vector3.Dot(transform.forward.normalized, raycastDirection.normalized));

                    float angleBetweenLeftAndObstacle = Mathf.Acos(Vector3.Dot(-transform.right.normalized, raycastDirection.normalized));
                    float angleBetweenRightAndObstacle = Mathf.Acos(Vector3.Dot(transform.right.normalized, raycastDirection.normalized));

                    if(angleBetweenLeftAndObstacle > angleBetweenRightAndObstacle)
                    {
                        angleBetweenObstacleAndBoid = -angleBetweenObstacleAndBoid;
                    }
                    else if(angleBetweenLeftAndObstacle == angleBetweenRightAndObstacle)
                    {
                        int randomNumber = Random.Range(0, 2);
                        if(randomNumber == 0)
                        {
                            angleBetweenObstacleAndBoid = -angleBetweenObstacleAndBoid;
                        }
                    }

                    isAvoidingObstacle = true;
                    transform.Rotate(Vector3.up, Mathf.Lerp(0, angleBetweenObstacleAndBoid, Time.deltaTime * rotateSpeed));

                    break;
                }
            }
        }

        if (!isAvoidingObstacle)
        {
            transform.LookAt(player.transform.position, Vector3.up);
        }

        if (moveDirections == IMovable.MoveDirections.Any)
        {
            if (player != null && (player.transform.position - transform.position).magnitude <= detectionDistance)
            {
                step = transform.forward * speed * Time.deltaTime;
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

    Vector3 Multiply(Matrix matrix, Vector3 vector)
    {
        Vector3 resultantVector = new Vector3();
        float[,] data = matrix.matrixData;

        resultantVector.x = Vector3.Dot(new Vector3(data[0, 0], data[0, 1], data[0, 2]), vector);
        resultantVector.y = Vector3.Dot(new Vector3(data[1, 0], data[1, 1], data[1, 2]), vector);
        resultantVector.z = Vector3.Dot(new Vector3(data[2, 0], data[2, 1], data[2, 2]), vector);

        return resultantVector;
    }

    struct Matrix
    {
       public float[,] matrixData;

        public Matrix(Vector3 topRow, Vector3 middleRow, Vector3 lastRow)
        {
            matrixData = new float[3, 3];

            matrixData[0, 0] = topRow.x;
            matrixData[0, 1] = topRow.y;
            matrixData[0, 2] = topRow.z;

            matrixData[1, 0] = middleRow.x;
            matrixData[1, 1] = middleRow.y;
            matrixData[1, 2] = middleRow.z;

            matrixData[2, 0] = lastRow.x;
            matrixData[2, 1] = lastRow.y;
            matrixData[2, 2] = lastRow.z;
        }
    }
}
