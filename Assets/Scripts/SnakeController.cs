using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    float points;
    public void IncreasePoints(float value)
    {
        points += value;
    }
}
