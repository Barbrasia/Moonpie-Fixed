using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OvenController : MonoBehaviour
{
    public GameObject door;
    public DOTweenAnimation doorAnimation;

    public GameObject tray;
    public DOTweenAnimation trayAnimation;

    private void Start()
    {
        doorAnimation = door.GetComponent<DOTweenAnimation>();
        trayAnimation = tray.GetComponent<DOTweenAnimation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            doorAnimation.DOPlay();
            trayAnimation.DOPlay();
        }
    }
}
