using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cone_color : MonoBehaviour
{
    // Start is called before the first frame update
    public Material mat;
    public Vector2 a;
    public Vector2 b;

    public Vector4 color; 

    float elapsed = 0f;
    void Start()
    {
       // mat.EnableKeyword("_EMISSION");
        GetComponent<Renderer>().material.EnableKeyword("_EmissionColor");
    }

    Vector2 oscila_0_255(Vector2 v)
    {

        if (v[0] > 255)
        {
            v[1] = 0;

        }
        if (v[0] < 0)
        {
            v[1] = 1;

        }
        if (v[1]==1)
        {
            v[0] = v[0] + 1;
        }
        else
        {
            v[0] = v[0] - 1;
        }
        return v;
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        Material mymat = GetComponent<Renderer>().material;
        //mymat.SetColor("_EmissionColor", Color.blue
        elapsed += Time.deltaTime;
        if (elapsed >= .01f)
        {
            elapsed = elapsed % .01f;
            a = oscila_0_255(a);
            b= oscila_0_255(b);

        }
        color = new Vector4( a[0] ,0, b[0],10)  ;
        mymat.SetVector("_EmissionColor", color);
        //Debug.Log(mymat.GetVector("_EmissionColor"));
       //Debug.Log(a);

    }
}
