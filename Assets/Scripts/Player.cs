using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    //TODO: Add two weapons to player "Find a pistol asset"
    public void FireWeapon(Transform WeaponTransform)
    {
        //Use the WeaponTransform to get the position and direction of the weapon
        //TODO: In case if there is common code in the fire functions "use physics raycast to fire weapon no need to spawn bullets"
        //TODO: Also check if fire hit a beat destroy the beat and increment the score using the score increment function
    }

    public void FireLeftWeapon(Transform WeaponTransform)
    {
        //TODO: Fire left Weapon
        Debug.Log("Fire left weapon");
    }

    public void FireRightWeapon(Transform WeaponTransform)
    {
        //TODO: Fire right Weapon
        Debug.Log("Fire right weapon");
    }

    public void ChargeWeapon()
    {
        //TODO: Charge Weapon(Reload)
        Debug.Log("Charging");
    }
}
