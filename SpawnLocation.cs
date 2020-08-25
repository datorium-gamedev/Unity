using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnLocation : MonoBehaviour
{
    //public GameObject objectToSpawn;
    public Rigidbody ObjToSpawn;
    public Camera myCamera;
    public float timer = 2.0f;
    private float bulletTimer;
    private bool canShoot = true;

    //public AudioClip myAudioClip;
    //private AudioSource myAudioSource;

    private void Start()
    {
        bulletTimer = timer;

        //myAudioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot == false)
        {
            bulletTimer -= Time.deltaTime;
        }

        if(bulletTimer <= 0)
        {
            canShoot = true;
        }

        //objectToSpawn.GetComponent<Rigidbody>().velocity = Vector3.forward;
        if (canShoot == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                ////myAudioSource.Play(); // TO PLAY THE SOUND ATTACHED TO THE AUDIO SOURCE
                //myAudioSource.PlayOneShot(myAudioClip); // TO PLAY ANY CLIP YOU PUT ON THE AUDIOCLIP SLOT
                //myAudioSource.volume = 0.75f; // CHANGE AUDIOSOURCE VOLUME 

                bulletTimer = timer;
                canShoot = false;
                Rigidbody objectClone;
                objectClone = Instantiate(ObjToSpawn, gameObject.transform.position, transform.rotation);
                objectClone.velocity = myCamera.transform.TransformDirection(Vector3.forward * 100);
                
            }
        }
    }



    public void myButtonFunction()
    {
        Rigidbody objectClone;
        objectClone = Instantiate(ObjToSpawn, gameObject.transform.position, transform.rotation);
        objectClone.velocity = myCamera.transform.TransformDirection(Vector3.forward * 100);

        Debug.Log("I pressed a button");
    }
}
