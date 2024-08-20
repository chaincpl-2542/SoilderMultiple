using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class MoveArea : MonoBehaviour
{
    public List<GameObject> allUnits;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 0; i++) 
        {
            allUnits[i].GetComponent<NavMeshAgent>().SetDestination(gameObject.transform.position);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 10);
    }
}
