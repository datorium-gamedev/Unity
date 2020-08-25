using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100.0f;

    private float rotationY = 0.0f;
    private float rotationX = 0.0f;

    private float xAxisClamp;
    public float xMaxClamp = 90; // Make sure to have the default value of 90 or something like that :)


    public Camera myCamera;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;

        rotationX = rotation.x;
        rotationY = rotation.y;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        // xMaxClamp = 90 in my case by default
        if (xAxisClamp > xMaxClamp)
        {
            xAxisClamp = xMaxClamp;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(-xMaxClamp);
        }

        else if (xAxisClamp < -xMaxClamp )
        {
            xAxisClamp = -xMaxClamp;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(xMaxClamp);
        }

        gameObject.GetComponent<Transform>().Rotate(Vector3.up * mouseX);
        myCamera.transform.Rotate(Vector3.left * mouseY);


        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;




        if (Input.GetMouseButtonDown(0))
            WeaponAim();
    }

    void WeaponAim()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, myCamera.transform.TransformDirection(Vector3.forward) * 10000);
        Debug.DrawRay(transform.position, myCamera.transform.TransformDirection(Vector3.forward) * 10000, Color.red);

        if (Physics.Raycast(myRay, out hit, 10000))
        {
            if (hit.collider.tag == "Cube")
                Debug.Log(hit.collider.name);
        }
    }

    // Have this for clamp restriction
    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        myCamera.transform.eulerAngles = eulerRotation;
    }





}