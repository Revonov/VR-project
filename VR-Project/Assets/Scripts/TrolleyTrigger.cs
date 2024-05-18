using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrolleyTrigger : MonoBehaviour
{
    private Vector3 targetPosition = new Vector3(0.01f, 0.05f, -0.4f);

    private float speed = 1f;

    private void OnTriggerEnter(Collider obj)
    {
        obj.tag = "1st trigger";
    }
    
}
