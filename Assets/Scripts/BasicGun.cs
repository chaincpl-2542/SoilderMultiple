using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : BaseGun
{
    public override void UpdateCondition()
    {
        base.UpdateCondition();
        Shoot();
        if(Input.GetKeyDown(KeyCode.C))
        {
            AddBulletSpeed(200);
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            AddFirerate(0.9f);
        }
    }
}
