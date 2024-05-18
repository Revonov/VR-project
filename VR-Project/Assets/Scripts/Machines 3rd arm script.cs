using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machines3rdarmscript : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        obj.tag = "3rd trigger";
        Destroy(gameObject);
    }

}
