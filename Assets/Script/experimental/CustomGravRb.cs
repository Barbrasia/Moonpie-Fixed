using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class CustomGravRb : MonoBehaviour
{
    [SerializeField] private bool floatToSleep = false;
    Rigidbody rb;
    private float floatDelay;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void FixedUpdate()
    {
        if (floatToSleep)
        {
            if(rb.IsSleeping())
            {
                floatDelay = 0f;
                return;
            }

            if (rb.velocity.sqrMagnitude < 0.0001f)
            {
                floatDelay += Time.deltaTime;
                if (floatDelay >= 1f)
                {
                    return;
                }
            }
            else
            {
                floatDelay = 0f;
            }
        }
        rb.AddForce(CustomGrav.GetGravity(rb.position), ForceMode.Acceleration);
    }
}
