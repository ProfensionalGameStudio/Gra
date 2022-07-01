using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class s : MonoBehaviour
{

    int i;
    [Header("Ten Obiekt")]
    public GameObject obj1;
    [Header("Początkowy")]
    public GameObject obj2;
    [Header("Środkowy")]
    public GameObject obj3;

    void OnTriggerStay(Collider other)
    {
        i = 1;
    }
    void OnTriggerExit(Collider other)
    {
        i = 0;
    }


    void Update()
    {
        if (i == 1 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = new Vector3(-5, 1, 0);
            Replace(obj1, obj2);
        }
        if (i == 1 && Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = new Vector3(5, 1, 0);
            Replaced(obj1, obj3);
        }
    }

    void Replace(GameObject obj1, GameObject obj2)
    {
        Instantiate(obj2, obj1.transform.position = new Vector3(-250, 1, 0), Quaternion.identity);
        DestroyImmediate(obj1, true);
    }
    void Replaced(GameObject obj1, GameObject obj3)
    {
        Instantiate(obj3, obj1.transform.position = new Vector3(0, 1, 0), Quaternion.identity);
        DestroyImmediate(obj1, true);
    }
}