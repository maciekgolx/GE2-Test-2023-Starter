using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject owner;
    public BoxCollider Decohedron;  
    public Transform target;
    public float speed = 50.0f;
    public int trigger=0;
    // Start is called before the first frame update
    void Start()
    {
        trigger=0;
    }
         
    public void OnCollisionEnter(Collision c)
    {
        owner.GetComponent<FPSController>().enabled = false;
        owner.GetComponent<FollowCamera>().enabled=true;
        trigger=1;
    }
       

    // Update is called once per frame
    void Update()
    {
        Debug.Log(trigger);
        if(trigger==1)
        {
            target.GetComponent<Boid>().enabled =false;
            if (Input.GetKey(KeyCode.W))
            {
                target.position=  target.position + new Vector3(Time.deltaTime*2, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                target.position=  target.position + new Vector3(0, Time.deltaTime*2, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                target.position=  target.position + new Vector3(-Time.deltaTime*2, 0, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                 target.position=  target.position + new Vector3(0, -Time.deltaTime*2, 0);
            }
        }
        if(Input.GetKey(KeyCode.Z))
        {
            target.GetComponent<Boid>().enabled =true;
        }
        if(Input.GetKey(KeyCode.X))
        {
            trigger=1;
        }
        if (Input.GetKey(KeyCode.N))
        {
            trigger=0;
            owner.GetComponent<FPSController>().enabled =true;
            owner.GetComponent<FollowCamera>().enabled=false;
        }
    }
}
