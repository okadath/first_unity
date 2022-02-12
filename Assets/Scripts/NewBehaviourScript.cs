using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material mat;

    void Start()
    {
       // mat.EnableKeyword("_EMISSION");
        GetComponent<Renderer>().material.EnableKeyword("_EmissionColor");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        Material mymat = GetComponent<Renderer>().material;
        //mymat.SetColor("_EmissionColor", Color.blue
        float inc = 10f;
        inc+=(Time.deltaTime * 1000 - 1) * 10;
        mymat.SetVector("_EmissionColor", new Vector4(inc , 176f, 100f, 10f) );
        Debug.Log(mymat.GetVector("_EmissionColor"));
       // Debug.Log();

    }
}
