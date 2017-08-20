using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    //  public Color color;
    public Material[] mat;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        
    }
    // Update is called once per frame
    void OnTouchDown()
    {
        rend.sharedMaterial = mat[0];
    }

    void OnTouchUp()
    {
        rend.sharedMaterial = mat[1];
    }

    void onTouchExit()
    {
        rend.sharedMaterial = mat[2];
    }


}
