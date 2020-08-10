using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{

    public float playerHealth = 10000f;
    public float myScore = 0;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Lavafloor")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("SomethingHappend");
        }
    }

private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Lavafloor")
        {
            Debug.Log("I am inside the trigger area");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Lavafloor")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("SomethingHappend");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lavafloor")
        {
            playerHealth -= 100f;
        }


        else if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            myScore += 100;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Lavafloor")
        {
            playerHealth -= 1f;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Lavafloor")
        {
            playerHealth = 10000;
        }
    }

}




