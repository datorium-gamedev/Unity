using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerCube : MonoBehaviour
{
    private PlayerStats myPlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        myPlayerStats = GameObject.Find("PlayerController").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        //if(collision.gameObject.name == "PlayerController")
        //{
            myPlayerStats.playerHealth -= 1;
        //}
    }
}
