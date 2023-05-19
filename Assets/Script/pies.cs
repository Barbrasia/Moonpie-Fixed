using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pies : MonoBehaviour
{
    public GameObject[] pie;
    private int activeIndex = 0;
    private Animator animator;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Awake()
    {
        foreach (GameObject pie in pie)
        {
            pie.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && activeIndex < pie.Length)
        {
            animator.SetBool("ActivatePie", true);
            pie[activeIndex].SetActive(true);
            activeIndex++;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("ActivatePie", false);
    }
}
