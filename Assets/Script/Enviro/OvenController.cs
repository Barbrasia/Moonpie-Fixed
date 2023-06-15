using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OvenController : MonoBehaviour
{
    public GameObject oven;
    public GameObject cake;

    public GameObject door;
    public DOTweenAnimation doorAnimation;

    public GameObject tray;
    public DOTweenAnimation trayAnimation;

    private void Awake()
    {
        Rigidbody rb = cake.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = true;
        }
    }

    private void Start()
    {
        doorAnimation = door.GetComponent<DOTweenAnimation>();
        trayAnimation = tray.GetComponent<DOTweenAnimation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("RollingPin") && Input.GetKey(KeyCode.E))
        {
            doorAnimation.DOPlay();
            trayAnimation.DOPlay();

            StartCoroutine(Finished());
        }
    }

    private IEnumerator Finished()
    {
        yield return new WaitForSeconds(7);
        GameObject.Destroy(oven);
    }
}
