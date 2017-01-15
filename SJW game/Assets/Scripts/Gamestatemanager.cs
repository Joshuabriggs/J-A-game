using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamestatemanager : MonoBehaviour {

    public StageManager sManager;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static Gamestatemanager instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("A Gamstatemanager instance already exists!");
        }
        instance = this;
    }
}
