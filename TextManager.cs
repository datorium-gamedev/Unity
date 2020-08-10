using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // <---- You need this

public class TextManager : MonoBehaviour
{

    public Text myText;
    public Text myTimer;
    private Toggle myToggle;
    public Slider mySlider;
    public GameObject myPlayer;

    //Replace int with float if you still have int
    public float playerHealth;
    public float timerValue = 60.0f;

    // Update is called once per frame
    void Update()
    {
        if (timerValue >= 0)
        {
            timerValue -= Time.deltaTime;
            
        }

        playerHealth = myPlayer.GetComponent<PlayerStats>().playerHealth;
        // Replaces the health with a value
        myText.text = "Health: " + playerHealth.ToString();
        myTimer.text = timerValue.ToString();

        //Slider based on value
        //Normalization means will turn range from 0 to 1 ( 2312 to 728372) 0 to 1 and if you get 0.5 it will be in the middle.
        //mySlider.value = (raw value - min) / (max - min);
        mySlider.value = (playerHealth - 0) / (100 - 0);
    }
}
