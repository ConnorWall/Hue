using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookDetector : MonoBehaviour
{

    public GameObject player;
    public GrapplingHook grapHook;
    // Start is called before the first frame update
        void OnTriggerEnter(Collider other)
        {
            if (this.tag == "Hookable")
           {

           
            //grapHook = player.GetComponent<GrapplingHook>();
        
            grapHook.hooked = true;
            grapHook.hookedobj = other.gameObject;
            }

        }
}
