using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI; // <---- You need this

public class TextManager : MonoBehaviour
{

    public Text myText;
    public Text myTimer;
    private Toggle myToggle;
    public Slider mySlider;
    public GameObject myPlayer;

    public GameObject myGameUI;
    public GameObject myMenuUI;
    private bool menuOpen = true;

    //Replace int with float if you still have int
    public float playerHealth;
    public float timerValue = 60.0f;

    private void Awake()
    {
        GameObject.Find("Menu").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Open and close main menu
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(menuOpen == true)
            {
                //Unlocks mouse when in menu
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;

                myGameUI.SetActive(false);
                myMenuUI.SetActive(true);

                Time.timeScale = 0.0f;
                menuOpen = false;
            }

            else if (menuOpen == false)
            {
                // Locks mouse when not in menu
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                myGameUI.SetActive(true);
                myMenuUI.SetActive(false);

                Time.timeScale = 1f;
                menuOpen = true;
            }

        }


        if (timerValue >= 0)
            timerValue -= Time.deltaTime; 

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
