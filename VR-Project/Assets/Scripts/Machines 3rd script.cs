using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machines3rdscript : MonoBehaviour
{

    private void OnTriggerEnter(Collider obj)
    {
        obj.tag = "3rd trigger";
        Destroy(gameObject);
    }
}
