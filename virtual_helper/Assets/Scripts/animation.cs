using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class animation : MonoBehaviour {

	// Use this for initialization
    Animator anim;
   // Animation anima;
    public float inhale1;
    public float exhale1;
    public float delay1;
    public float time_duration1;
	void Start () {
        
        anim = this.GetComponent<Animator>();
        
	}
    public void anim_start() 
    {
   
        anim.Play("Inhale");  

    }
    public void anim_dance()
    {
        anim.Play("rumba_dancing");

    }
    public void anim_pause()
    {
        anim.Play("idle");

    }
    public void anim_stop()
    {
        anim.Play("idle");

    }
	// Update is called once per frame
	void Update () {
        StreamReader sr = new StreamReader("D:/Diplom_program/virtual_helper/save.sg");
        while (!sr.EndOfStream)
        {
            inhale1 = System.Convert.ToInt32(sr.ReadLine());
            exhale1 = System.Convert.ToInt32(sr.ReadLine());
            delay1 = System.Convert.ToInt32(sr.ReadLine());
            time_duration1 = System.Convert.ToInt32(sr.ReadLine());
        }

        sr.Close();

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Inhale"))
        {
            anim.speed = 3f/inhale1;
        }
        else
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Delay_in"))
            {
                anim.speed = 4f/delay1;
            //anim.speed = 1f;
            }
            else
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("Exnhale"))
                {
                    anim.speed = 3f/exhale1;
                }
                else
                    if (anim.GetCurrentAnimatorStateInfo(0).IsName("Delay_ex"))
                    {
                        anim.speed = 4f / delay1;
                    }
                    else
                    {
                        anim.speed = 1f;
                    }

	}
}
