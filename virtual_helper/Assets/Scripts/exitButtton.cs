using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButtton : MonoBehaviour {

    public 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void exit() // остановка таймера
    {
        Application.LoadLevel(0);
    }
}
