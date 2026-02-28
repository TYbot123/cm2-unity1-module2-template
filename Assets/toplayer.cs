using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
   
    void Awake()
    {
      agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

      if(target == null) 
      {
        target = GameObject.FindGameObjectWithTag("Player")?.transform;
      }
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
