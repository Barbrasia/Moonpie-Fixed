using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIt : MonoBehaviour
{
    public GameObject hand;
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Hit");
        }
    }
}
