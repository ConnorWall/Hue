using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour


{
    public GameObject hook;
    public GameObject hookHolder;
    public GameObject FPS;
    public AudioSource hookAudio;
    

    public float hookTravelSpeed;
    public float playerTravelSpeed;

    public  bool fired;
    public  bool hooked;
    public GameObject hookedobj;

    public float maxDistance;
    private float currentDistance;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Hookable")
           {

           
            //grapHook = player.GetComponent<GrapplingHook>();
        
           hooked = true;
        hookedobj = other.gameObject;
        hookAudio.pitch = Random.Range(.5f,1.5f);
        hookAudio.Play();
            }

        }

    // Update is called once per frame
    void Update()

    {
      
        if (Input.GetMouseButtonDown(0) && fired == false)
        fired = true;

        if (fired)
        {
            LineRenderer beam = hook.GetComponent<LineRenderer>();
            beam.SetVertexCount(2);
            beam.SetPosition(0, hookHolder.transform.position);
            beam.SetPosition(1, hook.transform.position);
        }

        if (fired == true && hooked == false)
        {
          
            hook.transform.Translate(Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if (currentDistance >= maxDistance)
                ReturnHook();
        }

        if(hooked == true)
        {
                    
            hook.transform.parent = hookedobj.transform;
            transform.position = Vector3.MoveTowards(transform.position, hook.transform.position, Time.deltaTime * playerTravelSpeed);

                   hook.transform.Translate(-Vector3.forward * Time.deltaTime * hookTravelSpeed);
            currentDistance = Vector3.Distance(transform.position, hook.transform.position);

            if (currentDistance <= 2)
                ReturnHook();
                
            float distanceToHook = Vector3.Distance(transform.position,hook.transform.position);

            this.GetComponent<Rigidbody>().useGravity = false;


            if(distanceToHook < 2)
                ReturnHook();
        }
        else {
            hook.transform.parent = hookHolder.transform;
            this.GetComponent<Rigidbody>().useGravity = true;
        }
        
    }

    void ReturnHook()
    {
        
        hook.transform.rotation = hookHolder.transform.rotation;
        hook.transform.position = hookHolder.transform.position;
        fired = false;
        hooked = false;

LineRenderer beam = hook.GetComponent<LineRenderer>();
         beam.SetVertexCount(0);
        
    }
}
