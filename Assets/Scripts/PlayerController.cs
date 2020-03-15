using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{
    Player player;
    Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            player.FireRightWeapon(cameraTransform);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            player.FireLeftWeapon(cameraTransform);
        }
        if (Vector3.Dot(transform.forward,Vector3.forward) < -0.866)
        {
            player.ChargeWeapon();
        }
    }
}
