using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] float speedMove;

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }

    


    private void FixedUpdate()
    {
        
    }
}
