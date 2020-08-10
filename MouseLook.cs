using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100.0f;
    public float clampAngle = 80.0f;

    private float rotationY = 0.0f;
    private float rotationX = 0.0f;

    public Camera myCamera;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;

        rotationX = rotation.x;
        rotationY = rotation.y;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotationX += mouseY * mouseSensitivity * Time.deltaTime;
        rotationY += mouseX * mouseSensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);
        
        Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);

        gameObject.transform.rotation = localRotation;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        if(Input.GetMouseButtonDown(0))
        WeaponAim();
    }

    void WeaponAim()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, myCamera.transform.TransformDirection(Vector3.forward) * 10000);
        Debug.DrawRay(transform.position, myCamera.transform.TransformDirection(Vector3.forward) * 10000, Color.red);

        if(Physics.Raycast(myRay, out hit, 10000))
        {
            if (hit.collider.tag == "Cube")
                Debug.Log(hit.collider.name);
        }
    }



}
