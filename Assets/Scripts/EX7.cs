using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX7 : MonoBehaviour
{
    public string Operation;
    public float N1;
    public float N2;

    private void Start()
    {
        if(Operation == "sum")
        {
            Debug.Log($"{N1} + {N2} - {N1 + N2}");
        }
        else if (Operation == "substraction")
        {
            Debug.Log($"{N1} - {N2} - {N1 - N2}");
        }
        else if (Operation == "product")
        {
            Debug.Log($"{N1} * {N2} - {N1 - N2}");
        }
        else if(Operation == "division")
        {
            Debug.Log($"{N1} / {N2} - {N1 / N2}");
        }
       
    }
}
