using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsController : MonoBehaviour
{
    // V = e * t
    [SerializeField] float TimeForArrive;
    [SerializeField] PointsController pointNext;
    [SerializeField] TMP_Text textTimeNextPoint;
    private float distanceForNextPoint;


    public float GetTimeForArrive()
    {
        return TimeForArrive;
    }
    private void Start()
    {
            textTimeNextPoint.text = pointNext.GetTimeForArrive().ToString();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            distanceForNextPoint = Vector3.Distance(transform.position, pointNext.transform.position);
            
            other.gameObject.GetComponent<PlayerController>().SetVelocity(distanceForNextPoint / pointNext.GetTimeForArrive());
            other.gameObject.GetComponent<PlayerController>().SetNewPosition(pointNext.transform.position);


        }
    }





}
