using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject nave;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = nave.transform.position.x;
        transform.position = position;
    }
}
