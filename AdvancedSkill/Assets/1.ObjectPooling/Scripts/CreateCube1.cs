using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube1 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreateCoroutine());
    }

    IEnumerator CreateCoroutine()
    {
        while(true)
        {
            yield return null;
            GameObject t_object = ObjectPollingManager1.instance.GetQueue();
            t_object.transform.position = Vector3.zero;
        }
    }
}
