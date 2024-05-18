using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machines4thscript : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject Trigger;
    [SerializeField] GameObject oldDetail;
    [SerializeField] GameObject newDetail;

    private Vector3 targetPosition = new Vector3(0.01f, 0.05f, -0.4f);

    private void OnTriggerEnter(Collider obj)
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);
        Func();
    }

    private void Func()
    {
        obj.tag = "4th trigger";
        Trigger.transform.position = new Vector3(-1.959f, 0.529f, -1.45f);
        newDetail.transform.position = oldDetail.transform.position;
        Destroy(oldDetail);
    }

}
