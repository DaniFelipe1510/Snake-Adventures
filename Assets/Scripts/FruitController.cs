using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    [SerializeField]
    float points;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SnakeController controller =
                other.GetComponent<SnakeController>();
            controller.IncreasePoints(points);
            Destroy(controller.gameObject);
        }
    }
}
