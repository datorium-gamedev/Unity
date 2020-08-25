using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour
{
    public Material MyMaterial;
    public Texture myTexture;

    // Start is called before the first frame update
    void Start()
    {
        MyMaterial.SetTexture("_MainTex", myTexture); // This line to change materials texture in script
    }

    // Update is called once per frame
    void Update()
    {
        
        MyMaterial.SetColor("_Color", Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1)));

        //MyMaterial.SetColor("_Color", Color.white);

       
    }
}
