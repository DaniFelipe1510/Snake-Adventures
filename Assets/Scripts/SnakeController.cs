using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField]
    float speed = 10F;


    Vector2 direction = Vector2.zero;
    float points;

    void Start()
    {
        InvokeRepeating("UpdatePosition", 0, 1 / speed);
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        if(inputX > 0)
        {
            direction = Vector2.right;
        }else if(inputX < 0)
        {
            direction = Vector2.left;
        }else if(inputY > 0)
        {
            direction = Vector2.up;
        }else if (inputY < 0)
        {
            direction = Vector2.down;
        }
    }

    void UpdatePosition()
    {
        Vector3 headPosition = this.transform.position;
        Vector3 newPosition = new Vector3(headPosition.x + direction.x, headPosition.y + direction.y, 0.0F);
        transform.position = newPosition;
    }

    public void IncreasePoints(float value)
    {
        points += value;
    }
}
