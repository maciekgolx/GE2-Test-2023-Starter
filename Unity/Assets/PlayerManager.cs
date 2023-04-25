using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject owner;
    // Start is called before the first frame update
    void Start()
    {
        trigger=0;
    }
    class FindTargetState: State
    {
        public int trigger=0;
        public override void Enter()
        {
            if (trigger==0)
            {
                owner.GetComponent<FPSController>().enabled = true;
            }
        }
        public override void Exit()
        {
            if (trigger==0)
            {
                owner.GetComponent<FPSController>().enabled = false;
                owner.GetComponent<FollowCamera>().enabled=true;
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
