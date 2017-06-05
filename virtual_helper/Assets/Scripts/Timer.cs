using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Timer : MonoBehaviour {

    bool isOn = false; // по умолчанию выключен
    public float timer; // устанавливаем на 30 секунд
    public Text timerText; // куда выводить
    public int inhale;
    public int exhale;
    public int delay;
    public int time_duration;
    public int iValue;

    int minut;
    Animator anim;
    int inhaleHash = Animator.StringToHash("Inhale");
   

  public void TimerSwitch() // запуск таймера
    {
        isOn = !isOn; // вкл/выкл
        //anim.SetInteger("direction", 4);
    }

  public void TimerStop() // остановка таймера
  {
      isOn = false; // вкл/выкл
      timerText.text = System.Convert.ToString(time_duration + ":00");
      timer = time_duration * 60;
  }

  public void TimerPause() // пауза таймера
  {
      isOn = false; // вкл/выкл
      

  }
    void Start()
    {
        StreamReader sr = new StreamReader("D:/Diplom_program/virtual_helper/save.sg");
        while (!sr.EndOfStream)
        {
            inhale = System.Convert.ToInt32(sr.ReadLine());
            exhale = System.Convert.ToInt32(sr.ReadLine());
            delay = System.Convert.ToInt32(sr.ReadLine());
            time_duration = System.Convert.ToInt32(sr.ReadLine());
            timerText.text = System.Convert.ToString(time_duration+":00");
            timer = (time_duration * 60);
        }

        sr.Close();
        
    }

    void Update()
    {
        if (isOn) //если включен
        {
         //делаем таймер
            timer -= Time.deltaTime; // отнимаем 1 секунду
            iValue = (int)timer;
            
            minut = (iValue) / 60;
            timerText.text = minut + ":" + System.Convert.ToString((iValue)%60);

            if (iValue == 0)//остановка таймера
            {
                isOn = false;
            }

       }
    }
}
