using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : BaseGun
{
    public override void UpdateCondition()
    {
        base.UpdateCondition();
        Shoot();
    }
}
