using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    [SerializeField] GameObject oldDetail;
    [SerializeField] GameObject newDetail;

    Vector3 targetPosition = new Vector3(-2.07f, 0f, -0.86f);

    private void FixedUpdate()
    { 
        if (oldDetail != null)
        {
            if (oldDetail.tag == "3rd trigger")
            {
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, 1f * Time.deltaTime);
            }
        }
        if (tag == "4th trigger")
        {
            newDetail.tag = "4th trigger";
            Vector3 targetPosition = new Vector3(-2.19f, 0f, -1.11f);
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, 1f * Time.deltaTime);
        }
    }
}
