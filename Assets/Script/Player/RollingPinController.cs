using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPinController : MonoBehaviour
{
    public GameObject rollingPin;
    private int cupcakesCount;
    private bool rollingPinActive;

    private void Start()
    {
        rollingPin.SetActive(false);
        rollingPinActive = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cupcakesCount++;

            if (cupcakesCount >= 9 && !rollingPinActive)
            {
                ActivateRollingPin();
            }
        }
    }

    private void ActivateRollingPin()
    {
        rollingPin.SetActive(true);
        rollingPinActive = true;
        Debug.Log("wa³ek");
    }
}
