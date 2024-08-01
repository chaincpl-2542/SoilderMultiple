using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float damage;
    public void GetDamage(float _damage)
    {
        damage = _damage;
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Dummy")
        {
            other.gameObject.GetComponent<Dummy>().TakeDamage(damage);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
