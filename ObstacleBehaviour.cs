using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public int height = 10;//max height of Box's movement
    public int width = 10;
    public float yCenter;
    public float xCenter;
    public Transform Player;
    public float movSpeed = 5;
    public Rigidbody myRB;

    void Start()
    {
        myRB.isKinematic = true;
        yCenter = transform.position.y;
        xCenter = transform.position.x;
    }

    void Update()
    {
        ChasePlayer();
        //PingPongTranslate();
        //PingPongRigidBody();
    }

    private void FixedUpdate()
    {
        //PingPongRigidBody();
    }

    public void PingPongTranslate()
    {
        transform.position = new Vector3(transform.position.x, yCenter + Mathf.PingPong(Time.time, width), transform.position.z);//move on y axis only
    }

    public void PingPongRigidBody()
    {
        myRB.MovePosition(transform.position = new Vector3(transform.position.x, yCenter + Mathf.PingPong(Time.time, width), transform.position.z));//move on y axis only
    }

    public void ChasePlayer()
    {
        transform.LookAt(Player);

        transform.position += transform.forward * movSpeed * Time.deltaTime;
    }
    

}





//https://forum.unity.com/threads/ping-pong-gameobject-up-and-down-from-current-postion.226442/