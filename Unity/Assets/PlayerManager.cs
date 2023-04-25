using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject owner;
    public BoxCollider Decohedron;  
    // Start is called before the first frame update
    void Start()
    {

    }
         
    public void OnCollisionEnter(Collision c)
    {
        owner.GetComponent<FPSController>().enabled = false;
        owner.GetComponent<FollowCamera>().enabled=true;
    }
       

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            owner.GetComponent<FPSController>().enabled =true;
            owner.GetComponent<FollowCamera>().enabled=false;
        }
    }
}
