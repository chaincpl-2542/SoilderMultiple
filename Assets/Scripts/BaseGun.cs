using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGun : MonoBehaviour
{
    #region MainValue
    [SerializeField]private float damage;
    [SerializeField]private float criticalRate;
    [SerializeField]private float criticalDamage;
    [SerializeField]private float maxFireRate;
    [SerializeField]private float fireRate;
    [SerializeField]private GameObject bulletPrefab;
    [SerializeField]private Transform bulletPoint;
    

    private float bulletSpeed = 500;
    private bool readyToshoot;
    #endregion

    #region ReferentValue
    public float _damage;
    public float _fireRate;
    public float _bulletSpeed;
    public float _criticalRate;
    public float _criticalDamage;
    
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         UpdateCondition();
    }

    public virtual void UpdateCondition()
    {
        readyToshoot = CheckFireRate();
        ConfigValue();
    }
    public virtual void ConfigValue()
    {
        _damage = damage;
        _bulletSpeed = bulletSpeed;
        _criticalRate = criticalRate;
        _criticalDamage = criticalDamage;
    }

    public bool CheckFireRate()
    {
        if(fireRate > 0)
        {
            fireRate -= Time.deltaTime;
            return false;
        }
        else
        {
            return true;
        }
    }

    public virtual void Shoot()
    {
        if(readyToshoot)
        {
            OnShoot();
        }
    }

    public virtual void OnShoot()
    {
        GameObject bullet = Instantiate(bulletPrefab,bulletPoint.position,bulletPoint.rotation);
        bullet.GetComponent<Bullet>().GetDamage(damage);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet,5);
        fireRate = maxFireRate;
    }

    public void AddDamage(float AdditionalDamage)
    {
        damage += AdditionalDamage;
    }
    public void AddBulletSpeed(float Additionalspeed)
    {
        bulletSpeed += Additionalspeed;
    }

    public void AddFirerate(float AdditionalFireRate)
    {
        maxFireRate = maxFireRate * AdditionalFireRate;
    }
    public void AddCriticalDamage(float AdditionalCriDamage)
    {
        criticalDamage += AdditionalCriDamage;
    }

    public void AddCriRate(float AdditionalCriRate)
    {
        criticalRate += AdditionalCriRate;
    }
}
