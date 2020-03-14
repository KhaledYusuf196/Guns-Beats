using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    float velocity;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        velocity = -transform.position.z;
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.MovePosition(transform.position + Vector3.forward * velocity * Time.fixedDeltaTime);
    }
}
