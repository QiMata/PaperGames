using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchableObject : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Launch(float xSpeed,float ySpeed,float zSpeed)
    {
        rb.AddForce(new Vector3(xSpeed, ySpeed, zSpeed),ForceMode.Acceleration);
        rb.angularVelocity = new Vector3(6,0,0);
    }

    public void Freeze()
    {
        rb.velocity = new Vector3(0, 0, 0);
        rb.angularVelocity = new Vector3(0, 0, 0);
    }
}
