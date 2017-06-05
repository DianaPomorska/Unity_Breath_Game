using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataScript : MonoBehaviour {

    public int inhale;
    public int exhale;
    public int delay;
    public int time_duration;
    public Text myText;
	// Use this for initialization
	void Start () {
      //  GameObject.FindGameObjectWithTag("inhale").GetComponent<HingeJoint>();
       // pointsText = GetComponent<Text>();
           //     pointsText.text = "TEST";
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        inhale = 0;
        exhale = 0;
        delay = 0;
        time_duration = 0;

    }
}
