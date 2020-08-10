using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyMovementScript : MonoBehaviour
{
    public float playerSpeed = 100f;
    public float turnSpeed = 0.50f;
    public float YForce = 10f;
    public Rigidbody myRigid;
    public bool onGround = false;
    

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * playerSpeed;
        float verticalInput = Input.GetAxis("Vertical") * playerSpeed;

        Vector3 forwardMovement = gameObject.transform.forward * verticalInput * Time.deltaTime ;
        Vector3 rightMovement = transform.right * horizontalInput * Time.deltaTime;

        transform.Translate(Vector3.forward * verticalInput * playerSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * playerSpeed * Time.deltaTime);


        //transform.Rotate(transform.up * horizontalInput * turnSpeed);
        if (Input.GetButtonDown("Jump") && onGround == true)
        {
            myRigid.AddForce(new Vector3(0, YForce, 0), ForceMode.Impulse);
            onGround = false;
            Debug.Log("Jump");
        }
    }
}
