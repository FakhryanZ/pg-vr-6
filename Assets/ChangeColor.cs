using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color brown = new Color(0.819f, 0.266f, 0f);

    public void Red(){
       GetComponent<Renderer>().material.color = Color.red;
    }

    public void Brown(){
       GetComponent<Renderer>().material.color = brown;
    }

    public void Blue(){
       GetComponent<Renderer>().material.color = Color.blue;
    }
}
