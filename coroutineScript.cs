using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutineScript : MonoBehaviour
{
    public GameObject objToSpawn;
    private bool canSpawn = true;

    //private IEnumerator DisplayDebugLog(float timer)
    //{
    //    yield return new WaitForSeconds(timer);
    //    Debug.Log("Timer did something");
    //}

    private IEnumerator ObjSpawner(float spawnTimer)
    {
        yield return new WaitForSeconds(spawnTimer);
        Instantiate(objToSpawn, transform.position, transform.rotation);
        canSpawn = true;
        Debug.Log("I spawned an object");
    }

    private IEnumerator ObjSpawner1(float spawnTimer)
    {
        yield return new WaitForSeconds(spawnTimer);
        Debug.Log("SPAMBOT");
    }

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(DisplayDebugLog(3));
        StartCoroutine("ObjSpawner", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn == true)
        {
            StartCoroutine("ObjSpawner", 2);
            StartCoroutine("ObjSpawner1", 1);
            canSpawn = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            StopCoroutine("ObjSpawner");
            canSpawn = false;
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            StartCoroutine("ObjSpawner",1);
            canSpawn = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            StopAllCoroutines();
        }
    }
}
