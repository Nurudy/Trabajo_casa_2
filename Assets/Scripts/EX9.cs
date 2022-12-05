using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX9 : MonoBehaviour
{
    public bool wantsVegetarianOption;

    private void Start()
    {
        if (! wantsVegetarianOption)
        {
            Debug.Log($"Non-Vegetarian option coming soon");
        }
        else
        {
            Debug.Log($"Vegetarian option coming soon");
        }
    }
}
