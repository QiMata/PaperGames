using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private LaunchableObject _football;
    private bool _lanched;
	// Use this for initialization
	void Start () {
        _football = GameObject.Find("PaperFootball").GetComponent<LaunchableObject>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!_lanched)
        {
            _football.Launch(0, 0, -15);
        }
	}
}
