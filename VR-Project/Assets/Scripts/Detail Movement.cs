using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetailMovement : MonoBehaviour
{
    private Vector3 targetPosition = new Vector3(0.1f, 0.05f, -0.43f);
    private float speed = 0.25f;
    private void FixedUpdate()
    {
        if (tag == "1st trigger")
        {
            Vector3 target = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
        }
        if (tag == "2nd trigger")
        {
            targetPosition = new Vector3(-0.7f, 0.18f, 0.2f);

            Vector3 target = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
        }
        if (tag == "5th trigger")
        {
            targetPosition = new Vector3(0.1f, 0.05f, -0.43f);

            Vector3 target = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed * Time.deltaTime);
        }

    }
}
