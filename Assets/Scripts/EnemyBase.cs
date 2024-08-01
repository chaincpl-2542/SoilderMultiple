using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    private float hp = 100;
    private float armor = 0;
    private bool isDead;
    private GameObject textDamagePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void UpdateCondition()
    {
        isDead = DeadCheck();

        if(isDead)
        {
            OnDead();
        }
    }

    public bool DeadCheck()
    {
        if(hp <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public virtual void OnDead()
    {
        Destroy(gameObject,3f);
    }

    public virtual void TakeDamage(float damage)
    {
        GameObject textDamage = Instantiate(textDamagePrefab,gameObject.transform.position,gameObject.transform.rotation);
        textDamage.GetComponent<TMP_Text>().text = damage.ToString();
        hp =  damage - armor;
    }
}
