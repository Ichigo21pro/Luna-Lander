using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        //hacer que mire la camara al objeto
        transform.LookAt(target);

        
    }
}
