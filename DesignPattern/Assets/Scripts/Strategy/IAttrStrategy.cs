using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAttrStrategy
{
    //初始的属性
    public abstract void InitAttr(ICharacterAttr _characterAttr);

    //攻击加成
    public abstract int GetAtkPlusValue(ICharacterAttr _characterAttr);

    //获取减少伤害值
    public abstract int GetDmgDescValue(ICharacterAttr _characterAttr);
}
