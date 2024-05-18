using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    private bool done = false;

    void Update()
    {
        if (!done)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0f, 90f, 0f), 3f * Time.deltaTime);
        }
        StartCoroutine(Wait());
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(4f);
        Func();
    }

    private void Func()
    {
        done = true;
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0f, 0f, 0f), 2f * Time.deltaTime);
    }
    
}
