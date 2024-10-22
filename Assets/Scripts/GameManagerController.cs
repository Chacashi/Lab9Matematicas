using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{

   [SerializeField] GameObject[] arrayPoints;
    [SerializeField] PlayerController player;



    private void Start()
    {
        SetInitialPosition();
    }
    void SetInitialPosition()
    {
        int position = Random.Range(0, arrayPoints.Length);
        player.SetNewPosition(arrayPoints[position].transform.position);

    }


}
