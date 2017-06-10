using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flubber : MonoBehaviour
{
    private Rigidbody _ridgidBody;

    void Start()
    {
        _ridgidBody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _ridgidBody.AddForce(new Vector3(collision.impulse.x * 50, collision.impulse.y * 50, collision.impulse.z * 50));
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
