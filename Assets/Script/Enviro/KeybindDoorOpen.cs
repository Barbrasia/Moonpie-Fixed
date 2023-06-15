using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybindDoorOpen : MonoBehaviour
{
    public GameObject Instruction;
    public OpenDoor openDoor;
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
            openDoor.DoorRotate();
            Instruction.SetActive(false);
            Action = false;

            StartCoroutine(openDoor.CloseDoor());

        }
    }
}
