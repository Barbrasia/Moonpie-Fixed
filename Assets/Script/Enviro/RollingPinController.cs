using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingPinController : MonoBehaviour
{
    public GameObject rollingPin;
    public int cupcakesCount;

    private void Start()
    {
        rollingPin.SetActive(false);
    }

    private void Update()
    {
        if (cupcakesCount == 1)
        {
            ActivateRollingPin();
        }
    }

    private void ActivateRollingPin()
    {
        rollingPin.SetActive(true);
        Debug.Log("ale wa³ek");
    }
}
