using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    BasicGun basicGun;
    // Start is called before the first frame update
    void Start()
    {
        basicGun = gameObject.GetComponent<BasicGun>();
        
        if(!basicGun)
        {
            basicGun = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BasicGun>();
        }
    }

    public void AddBulletDamage(float damage)
    {
        basicGun.AddDamage(damage);
    }

    public void AddBulletSpeed(float bulletSpeed)
    {
        basicGun.AddBulletSpeed(bulletSpeed);
    }

    public void AddFireSpeed(float fireRate)
    {
        basicGun.AddBulletSpeed(fireRate);
    }

    public void AddCriticalDamage(float criticalDamage)
    {
        basicGun.AddBulletSpeed(criticalDamage);
    }
    public void AddCriRate(float CriRate)
    {
        basicGun.AddBulletSpeed(CriRate);
    }
}
