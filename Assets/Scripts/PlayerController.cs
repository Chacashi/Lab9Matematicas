using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    [SerializeField] float velocity;
    [SerializeField] TMP_Text textVelocity;
    [SerializeField]  Vector3 PositionToMove;

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
       
    }

    private void Start()
    {
        textVelocity.text = "Velocidad: " + velocity.ToString();
        
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,PositionToMove,velocity * Time.deltaTime);
    }

    public void SetNewPosition(Vector3 newPosition)
    {
     PositionToMove = newPosition;
    }
    public void SetVelocity(float _velocity)
    {
        velocity = _velocity;
        textVelocity.text = "Velocidad: " + velocity.ToString();
    }

    

    


}
