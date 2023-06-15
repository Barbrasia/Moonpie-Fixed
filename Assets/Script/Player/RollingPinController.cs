using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingPinController : MonoBehaviour
{
    public GameObject rollingPin;
    private int cupcakesCount;
    public Cupcakes cupcakes;

    private void Start()
    {
        rollingPin.SetActive(false);
        cupcakesCount = cupcakes.activeIndex;
    }

    private void Update()
    {
        if (cupcakesCount == 10)
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
