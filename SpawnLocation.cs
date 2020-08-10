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

    private void Start()
    {
        bulletTimer = timer;
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
