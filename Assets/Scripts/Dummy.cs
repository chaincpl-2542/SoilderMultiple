using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dummy : EnemyBase
{
    public TMP_Text damageText;
    public override void TakeDamage(float damage)
    {
        damageText.text = damage.ToString();
        
        base.TakeDamage(damage);
    }
}
