using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTableTrigger : MonoBehaviour
{
    private Vector3 targetPosition = new Vector3(0.01f, 0.05f, -0.4f);

    private float speed = 1f;

    private void OnTriggerEnter(Collider obj)
    {
        obj.tag = "2nd trigger";
        if(obj.name != "Cube")
        {
            Destroy(gameObject);
        } 
    }

}
