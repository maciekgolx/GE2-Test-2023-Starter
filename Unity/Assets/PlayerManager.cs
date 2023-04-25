using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject owner;
    public GameObject Decohedron;
    // Start is called before the first frame update
    void Start()
    {
        owner.GetComponent<FPSController>().enabled = false;
        owner.GetComponent<FollowCamera>().enabled=true;
    }
         
    public void OnTriggerEnter(Collider c)
    {

    }
       

    // Update is called once per frame
    void Update()
    {
        
    }
}
