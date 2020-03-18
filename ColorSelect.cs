using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSelect : MonoBehaviour
{
private Color randomColor;

    // Start is called before the first frame update
    void Start()
    {
        randomColor = Random.ColorHSV(0f, 1f, .4f, .6f, .7f, 1f, 0f, 1f);
        GetComponent<Renderer>().material.color = randomColor;
        GetComponent<Light>().color = randomColor;
        
    }

    // Update is called once per frame
    void Update()

    {

        
    }
}
