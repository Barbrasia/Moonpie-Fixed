using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketToFinal : MonoBehaviour
{
    public GameObject rocket;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Rakieta");
        if (other.CompareTag("Player") && Input.GetKey(KeyCode.E))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
