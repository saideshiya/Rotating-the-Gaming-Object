using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rotate : MonoBehaviour
{
    void Start()
    {   
    }
    void Update()
    {
        transform.RotateAround(Vector3.up,Vector3.left,40*Time.deltaTime);
    }
}
