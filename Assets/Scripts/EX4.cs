using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    public float BaseX;
    public float HeightY;

    private void Start()
    {
        if(BaseX < 0 || HeightY < 0)
        {
            Debug.Log($"The base or the height are negative and the area can't be calculated");
        }
        else
        {
            Debug.Log($"The area of the triangle it's {(BaseX * HeightY) / 2}");
        }
    }
}
