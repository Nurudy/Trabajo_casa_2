using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX3 : MonoBehaviour
{
    public int Divide;
    private void Start()
    {
        if(Divide % 5 == 0)
        {
            Debug.Log($"The number {Divide} is divisible by5");
        }
        else
        {
            Debug.Log($"The number {Divide} is not divisible by 5");
        }
    }




}









