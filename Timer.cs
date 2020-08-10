using Boo.Lang.Environments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float myTimer = 3.0f;
    public GameObject myPlayer;

    

    // Update is called once per frame
    void Update()
    {
        
        if(myTimer >= 0 )
        {
            myTimer -= Time.deltaTime;
            //To have nice numbers when deducting like from 1.49484327 to 1.49
            myTimer = Mathf.Round(myTimer * 100f) / 100f;


            Debug.Log(myTimer);

            if (myTimer < 0)
            {
                myTimer = 0;
            }
              
        }

        if(myTimer <= 0)
        {
           // myPlayer.SetActive(true);
        }
    }
}
