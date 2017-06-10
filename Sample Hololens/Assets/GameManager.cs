using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    private TextMesh _goal;
    private LaunchableObject _football;
    private GoalPostScript _goalPost;
    private bool _lanched;
	// Use this for initialization
	void Start () {
        _football = GameObject.Find("PaperFootball").GetComponent<LaunchableObject>();
        _goal = GameObject.Find("Goal").GetComponent<TextMesh>();
        _goalPost = GameObject.Find("GoalPost").GetComponentInChildren<GoalPostScript>();
        _goalPost.Reset();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!_lanched)
        {
            _football.Launch(0, 0, -600);
            _lanched = true;
        }
        if (_goalPost.WentThroughUpright)
        {
            _goal.text = "Goal!!!";
        }
	}
}
