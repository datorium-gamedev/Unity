using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    public Text mytext;
    public float number = 100;

    public Toggle myToggle;
    public Slider mySlider;

    public EventSystem myEventSystem;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (myToggle.isOn == true)
        {
            mySlider.value -= Time.deltaTime;
        }



        mytext.text = mySlider.value.ToString();

        //Slider based on value
        //mySlider.value = (number - 0) / (100 - 0);


    }

    public float getNumber()
    {
        return number;
    }
}
