using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField]
    float speed = 10F;

    Vector3 direction = Vector3.zero;

    float points;


    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * Time.deltaTime * speed;
    }

    public void IncreasePoints(float value)
    {
        points += value;
    }
}
