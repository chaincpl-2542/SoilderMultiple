using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private float hp = 100;
    [SerializeField] private float armor = 0;
    private bool isDead;

    #region refferent
    public float _currentHp;
    public float _currentArmor;
    #endregion
    [SerializeField] private GameObject textDamagePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentHp = hp;
        _currentArmor = armor;
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
        textDamage.GetComponent<TextDamage>().SetDamageText(damage);
    
        hp -=  damage - armor;
    }
}
