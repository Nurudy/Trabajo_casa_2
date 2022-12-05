using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX10 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        if(year % 4 == 0 || year % 100 > 0 || year % 400 == 0)
        {
            Debug.Log($"The year {year} it's a leap year");
        }
        else
        {
            Debug.Log($"The year {year} it is not a leap year");
        }
    }
}
