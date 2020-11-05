using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStrategy : IAttrStrategy
{
    public override int GetAtkPlusValue(ICharacterAttr _characterAttr)
    {
        EnemyAttr theEnemyAttr = _characterAttr as EnemyAttr;
        if (theEnemyAttr == null)
            return 0;

        //按暴击概率返回攻击加成值
        int randValue = UnityEngine.Random.Range(0, 100);
        if (theEnemyAttr.GetCritRate() >= randValue)
        {
            theEnemyAttr.CutdownCritRate();
            return theEnemyAttr.GetMaxHP() * 5;
        }
        return 0;
    }

    public override int GetDmgDescValue(ICharacterAttr _characterAttr)
    {
        return 0;
    }

    public override void InitAttr(ICharacterAttr _characterAttr)
    {
        //不用计算
    }
}