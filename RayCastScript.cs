using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    public Vector3 rayLength = new Vector3(0, 1, 0);
    public GameObject myPlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckGround();
    }

    private void OnDrawGizmos()
    {
        CheckGround();
    }

    void CheckGround()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.TransformDirection(Vector3.down) * rayLength.y);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * rayLength.y, Color.red);

        myPlayer.GetComponent<MyMovementScript>().onGround = false;

        if (Physics.Raycast(myRay, out hit, rayLength.y))
        {
            if (hit.collider.name == "Floor")
                myPlayer.GetComponent<MyMovementScript>().onGround = true;
            //Debug.Log(hit.collider.name);
        }
               
    }
}
