﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("PlayerController").GetComponent<PlayerStats>().playerScore += 1;
        Instantiate(explosion, gameObject.transform.position, transform.rotation);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
