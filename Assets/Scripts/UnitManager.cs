using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.AI;

public class UnitManager : MonoBehaviour
{
    public GameObject unitPrefab;
    public List<GameObject> playerUnit;
    // Start is called before the first frame update
    void Start()
    {
       
        SpawnUnit(1);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < playerUnit.Count; i++) 
        {
            playerUnit[i].GetComponent<NavMeshAgent>().SetDestination(gameObject.transform.position);
        }
    }

    public void SpawnUnit(int amount)
    {
        GameObject unit = Instantiate(unitPrefab, gameObject.transform.position, gameObject.transform.rotation);
        playerUnit.Add(unit);
    }
}
