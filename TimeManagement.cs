using Boo.Lang.Environments;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagement : MonoBehaviour
{
    //10 Second timer
    public float myTimer = 10.0f;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (myTimer > 0)
        {
        myTimer -= Time.deltaTime;
        Debug.Log(myTimer);
        }

        if (myTimer <= 0)
        { 
            Debug.Log("Times up!");
        }
    }
}
