using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OpenDoor : MonoBehaviour
{
    public float doorAngle;
    public float doorSpeed;

    public void DoorRotate()
    {
        transform.DOLocalRotate(new Vector3 (doorAngle, 0, 0), doorSpeed);
    }

    public IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        transform.DOLocalRotate(new Vector3(90, 0, 0), doorSpeed);
    }

}
