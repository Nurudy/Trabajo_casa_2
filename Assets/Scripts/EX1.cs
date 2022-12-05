using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    public float number;

    private void Start()
    {
        if (number > 0)
        {
            Debug.Log($"El numero {number} es positivo");
        }
        else
        {
            Debug.Log($"El numero {number} es negativo");
        }
    }
}
