using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybindDoorOpen : MonoBehaviour
{
    public GameObject Instruction;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && Action == true)
        {
            Instruction.SetActive(false);
            Action = false;
        }
    }
}
