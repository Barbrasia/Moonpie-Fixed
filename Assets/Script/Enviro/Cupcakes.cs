using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupcakes : MonoBehaviour
{
    public GameObject[] cupcakes;
    public int activeIndex = 0;
    private Animator animator;
    public RollingPinController rollingPin;

    [SerializeField]
    private UIManager uiManager;

    [SerializeField]
    private RollingPinController rollingPinController;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Awake()
    {
        foreach (GameObject cupcakes in cupcakes)
        {
            cupcakes.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && activeIndex < cupcakes.Length)
        {
            animator.SetBool("ActivateCupcake", true);
            cupcakes[activeIndex].SetActive(true);
            activeIndex++;

            uiManager.UpdateCupcakeIndex(activeIndex);
            rollingPin.cupcakesCount++;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("ActivateCupcake", false);
    }

    // && other.CompareTag("Cupcake")
}
