using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform orb;

    void Start()
    {
        for (int i=0; i<250; i++)
        {
            Instantiate(orb, new Vector3(Random.Range(-50f, 50f), Random.Range(20f, 1200F), Random.Range(-50f, 50f)), Quaternion.Euler(0,90f,0));

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
