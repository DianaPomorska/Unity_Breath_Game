using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Save : MonoBehaviour {
    public string inhale;
    public string exhale;
    public string delay;
    public string time_duration;
    public Text slider_inhale;
    public Text slider_exhale;
    public Text slider_delay;
    public Text slider_time_duration;
    public string filename;
    public Slider sliderInhale;
    public Slider sliderExhale;
    public Slider sliderDelay;
    public Slider sliderTimeDuration;

	// Use this for initialization
	void Start () {
      
        StreamReader sr = new StreamReader("D:/Diplom_program/virtual_helper/save.sg");
        while (!sr.EndOfStream)
        {
            slider_inhale.text = System.Convert.ToString(sr.ReadLine());
            inhale = slider_inhale.text; 
            sliderInhale.value = System.Convert.ToInt32(inhale);

            slider_exhale.text = System.Convert.ToString(sr.ReadLine());
            exhale = slider_exhale.text;
            sliderExhale.value = System.Convert.ToInt32(exhale);

            slider_delay.text = System.Convert.ToString(sr.ReadLine());
            delay = slider_delay.text;
            sliderDelay.value = System.Convert.ToInt32(delay);

            slider_time_duration.text = System.Convert.ToString(sr.ReadLine());
            time_duration = slider_time_duration.text;
            sliderTimeDuration.value = System.Convert.ToInt32(time_duration);
            
        }

        sr.Close();
		
	}
   public void onGUI()
    {
       /* if (GUI.Button(new Rect(10, 10, 60, 20), "save"))
        {*/
            
       // }
            

    }
	
	// Update is called once per frame
	void Update () {
        inhale = slider_inhale.text;
        exhale = slider_exhale.text;
        delay = slider_delay.text;
        time_duration = slider_time_duration.text;

        StreamWriter sw = new StreamWriter("D:/Diplom_program/virtual_helper/save.sg");
        sw.WriteLine(slider_inhale.text);
        sw.WriteLine(exhale);
        sw.WriteLine(delay);
        sw.WriteLine(time_duration);
        //Debug.Log("save " + exhale);
        sw.Close();

	}
}
