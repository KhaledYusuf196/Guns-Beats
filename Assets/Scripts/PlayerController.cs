using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerController : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            player.FireRightWeapon();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            player.FireLeftWeapon();
        }
        if (Vector3.Dot(transform.forward,Vector3.forward) < -0.866)
        {
            player.ChargeWeapon();
        }
    }
}
