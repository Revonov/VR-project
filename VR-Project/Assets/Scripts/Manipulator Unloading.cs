using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class ManipulatorUnloading : MonoBehaviour
{
    [SerializeField] GameObject Trolley;
    bool done = false;
    bool stop = false;

    private void FixedUpdate()
    {
        if (!done)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(65f, -120f, -38f), 1.5f * Time.deltaTime);
        }
        //Quaternion.LookRotation(Trolley.transform.position - transform.position)
        if (tag == "1st trigger")
        {
            done = true;
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(49.5f, -39.5f, -4.2f), 1.5f * Time.deltaTime);
        }

        if (tag == "2nd trigger")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(28.9f, -180f, -3.6f), 1.5f * Time.deltaTime);
        }
        if (tag == "3rd trigger")
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(28.9f, -140f, -3.6f), 1.5f * Time.deltaTime);
        }
        if (tag == "5th trigger" && !stop)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(28.9f, -180f, -3.6f), 1.5f * Time.deltaTime);
            
            if (transform.localEulerAngles.y < 185) stop = true;
        }
        if (tag == "5th trigger" && stop)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(49.5f, -39.5f, -4.2f), 1.5f * Time.deltaTime);
        }
    }
}
