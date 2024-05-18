using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machines5thscript : MonoBehaviour
{
    [SerializeField] GameObject Detail;
    [SerializeField] GameObject Manipulator;

    private void OnTriggerEnter(Collider obj)
    {
        obj.tag = "5th trigger";
        Detail.tag = obj.tag;
        Manipulator.tag = obj.tag;
    }
}
