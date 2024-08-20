using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerUnit : MonoBehaviour
{
    public Transform target;
    public float turnSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        FindClosestEnemy();
        // Calculate the direction to the target
        Vector3 directionToTarget = FindClosestEnemy().transform.position - transform.position;

        // Ensure the object stays at the same height as the target
        directionToTarget.y = 0;

        // Calculate the target rotation based on the direction
        float targetAngle = Mathf.Atan2(directionToTarget.x, directionToTarget.z) * Mathf.Rad2Deg;
        Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);

        // Smoothly rotate towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);


    }
    public EnemyBase FindClosestEnemy()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        EnemyBase closestEnemy = null;
        EnemyBase[] allEnemies = GameObject.FindObjectsOfType<EnemyBase>();

        foreach (EnemyBase currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
            if(distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
            }
        }
        Debug.DrawLine(this.transform.position, closestEnemy.transform.position);
        return closestEnemy;
    }
}
