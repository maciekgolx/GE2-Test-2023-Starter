using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FollowBoid : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent Boid;
    public Transform Decohedron;
    public GameObject boid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        Boid.SetDestination(Decohedron.position);
        Boid.speed = boid.GetComponent<Boid>().maxSpeed;
    }
}
