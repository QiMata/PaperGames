using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPostScript : MonoBehaviour
{
    public bool WentThroughUpright { get; private set; }
                                       // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        WentThroughUpright = true;
	}

    public void Reset()
    {
        WentThroughUpright = false;
    }
}
