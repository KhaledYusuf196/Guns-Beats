using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    ScoreManager scoreManager;
    [SerializeField] GameObject PistolLeft;
    [SerializeField] GameObject PistolRight;
    [SerializeField] GameObject Bullets;
    [SerializeField] Camera camera;
    private LineRenderer laserLine;                                        // Reference to the LineRenderer component which will display our laserline
    public int gunDamage = 1;                                            // Set the number of hitpoints that this gun will take away from shot objects with a health script
    public float fireRate = 0.25f;                                        // Number in seconds which controls how often the player can fire
    public float weaponRange = 50f;                                        // Distance in Unity units over which the player can fire
    public float hitForce = 100f;                                        // Amount of force which will be added to objects with a rigidbody shot by the player
    public Transform Left;
    public Transform Right;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        laserLine = GetComponent<LineRenderer>();

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
        //WeaponTransform = PistolLeft.transform;
        //var bullet = Instantiate(Bullets, WeaponTransform.position, WeaponTransform.rotation);
    
        Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        // Declare a raycast hit to store information about what our raycast has hit
        RaycastHit hit;

        // Set the start position for our visual effect for our laser to the position of gunEnd
        laserLine.SetPosition(0, Right.position);

        // Check if our raycast has hit anything
        if (Physics.Raycast(rayOrigin, camera.transform.forward, out hit, weaponRange))
        {
            // Set the end position for our laser line 
            laserLine.SetPosition(1, hit.point);

            // Get a reference to a health script attached to the collider we hit
            Beat health = hit.collider.GetComponent<Beat>();
            if (health)
            {
                health.gameObject.SetActive(false);
                scoreManager.IncrementScore();

            }

          
           
        }
        else
        {
            // If we did not hit anything, set the end of the line to a position directly in front of the camera at the distance of weaponRange
            laserLine.SetPosition(1, rayOrigin + (camera.transform.forward * weaponRange));
        }

            Debug.Log("Fire left weapon");
    }

    public void FireRightWeapon(Transform WeaponTransform)
    {
        Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

        // Declare a raycast hit to store information about what our raycast has hit
        RaycastHit hit;

        // Set the start position for our visual effect for our laser to the position of gunEnd
        laserLine.SetPosition(0, Left.position);

        // Check if our raycast has hit anything
        if (Physics.Raycast(rayOrigin, camera.transform.forward, out hit, weaponRange))
        {
            // Set the end position for our laser line 
            laserLine.SetPosition(1, hit.point);

            // Get a reference to a health script attached to the collider we hit
            Beat health = hit.collider.GetComponent<Beat>();
            if (health)
            {
                health.gameObject.SetActive(false);
                scoreManager.IncrementScore();

            }



        }
        else
        {
            // If we did not hit anything, set the end of the line to a position directly in front of the camera at the distance of weaponRange
            laserLine.SetPosition(1, rayOrigin + (camera.transform.forward * weaponRange));
        }
        //TODO: Fire right Weapon
        Debug.Log("Fire right weapon");
    }

    public void ChargeWeapon()
    {
        //TODO: Charge Weapon(Reload)
        Debug.Log("Charging");
    }
}
