using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX6 : MonoBehaviour
{
    public float DistanceTraveled;
    public float DistanceToBeTravel;

    private void Start()
    {
        if(DistanceToBeTravel - DistanceTraveled <= 0)
        {
            Debug.Log($"Great! You have completed the total distance!");
        }
        else
        {
            Debug.Log($"Oh… You still have {DistanceToBeTravel - DistanceTraveled} meters left to complete the total distance");
        }
    }
}
