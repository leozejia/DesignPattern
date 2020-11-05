using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierStrategy : IAttrStrategy
{
    public override int GetAtkPlusValue(ICharacterAttr _characterAttr)
    {
        return 0;
    }

    public override int GetDmgDescValue(ICharacterAttr _characterAttr)
    {
        SoldierAttr theSoldierAttr = _characterAttr as SoldierAttr;
        if (theSoldierAttr == null)
            return 0;

        //返回减少伤害值
        return (theSoldierAttr.GetSoldierLv() - 1) * 2;
    }

    public override void InitAttr(ICharacterAttr _characterAttr)
    {
        SoldierAttr theSoldierAttr = _characterAttr as SoldierAttr;
        if (theSoldierAttr == null)
            return;

        //最大生命力有等级加成
        int addMaxHP = 0;
        int lv = theSoldierAttr.GetSoldierLv();
        if (lv > 0)
            addMaxHP = (lv - 1) * 2;

        //设置最高HP
        theSoldierAttr.AddMaxHP(addMaxHP);
    }
}
