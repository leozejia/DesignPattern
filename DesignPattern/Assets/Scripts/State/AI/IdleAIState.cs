using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAIState : IAIState
{
    private bool bSetAttackPosition = false;        //是否设置了攻击目标

    public IdleAIState() { }

    //设置要攻击的目标
    public override void SetAttackPosition(Vector3 _attackPosition)
    {
        bSetAttackPosition = true;
    }

    public override void Update(List<ICharacter> _targets)
    {
        //没有目标时
        if (_targets == null || _targets.Count == 0)
        {
            //有设置目标时，往目标移动
        }
    }
}
