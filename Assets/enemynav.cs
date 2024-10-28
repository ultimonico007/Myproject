using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemynav : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("setdestination", 2f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
     
 
    }
    public void setdestination()
    {
        agent.destination = player.position;
    }
}
