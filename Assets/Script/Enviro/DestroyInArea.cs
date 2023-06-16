using UnityEngine;

public class DestroyInArea : MonoBehaviour
{
    private bool flag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            flag = true;
        }
    }
}
