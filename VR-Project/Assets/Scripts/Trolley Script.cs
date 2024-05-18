using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrolleyScript : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 targetPosition = new Vector3(-1.1f, 0.2f, -1.3f);
    private float speed = 1f;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()

    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

}
