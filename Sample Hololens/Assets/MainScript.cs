using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {
    private Button _mainTextButton;
	// Use this for initialization
	void Start () {
        _mainTextButton = GameObject.Find("TestMain").GetComponent<Button>();
        _mainTextButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
