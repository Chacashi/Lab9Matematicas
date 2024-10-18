using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _compRigidbody;

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other!=null && other.gameObject.tag == "CubeZ")
        {

        }
        else if (other != null && other.gameObject.tag == "CubeX")
        {

        }
    }


    private void FixedUpdate()
    {
        
    }
}
