using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAcquisition : MonoBehaviour
{
    public int cupcakesNeeded = 10; 
    public int currentCupcakes = 0; 

    public GameObject weaponToAcquire; 
    public Transform weaponSlot; 

    private bool weaponAcquired = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cupcake"))
        {
            currentCupcakes++; 

            if (!weaponAcquired && currentCupcakes >= cupcakesNeeded)
            {
                AcquireWeapon(); 
            }
        }
    }

    private void AcquireWeapon()
    {
        weaponAcquired = true;

        GameObject acquiredWeapon = Instantiate(weaponToAcquire, weaponSlot.position, weaponSlot.rotation);
        acquiredWeapon.transform.SetParent(weaponSlot); 

        Debug.Log("Weapon acquired: " + weaponToAcquire.name);
    }
}
