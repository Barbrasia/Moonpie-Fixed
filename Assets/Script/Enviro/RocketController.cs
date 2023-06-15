using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public int piesCount;
    public GameObject rocket;
    private bool flag;

    private void Update()
    {
        if (piesCount == 6 && !flag)
        {
            GameObject newObject = new GameObject("Rocket");

            newObject.transform.position = new Vector3(50, 50, -30);

            GameObject model = Instantiate(rocket, new Vector3(50, 50, -30), Quaternion.identity); 
            model.transform.parent = newObject.transform;

            flag = true;
        }
    }
}
