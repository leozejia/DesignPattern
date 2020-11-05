using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacterAttr
{
    protected int maxHP = 0;
    protected int nowHP = 0;
    protected float moveSpeed = 1.0f;
    protected string attrName = "";

    protected IAttrStrategy attrStrategy = null;


    public void SetAttrStrategy(IAttrStrategy _theAttrStrategy)
    {
        attrStrategy = _theAttrStrategy;
    }

    public IAttrStrategy GetAttrStrategy()
    {
        return attrStrategy;
    }

    public virtual void InitAttr()
    {
        attrStrategy.InitAttr(this);
        //FullNowHP();
    }

    //攻击加成
    public int GetAtkPlusValue()
    {
        return attrStrategy.GetAtkPlusValue(this);
    }

    //获取被武器攻击后的伤害
    public void CalDmgValue(ICharacter attacker)
    {
        //获取武器攻击力
        int atkValue = attacker.GetAtkValue();

        //减少伤害值
        atkValue -= attrStrategy.GetDmgDescValue(this);

        //扣去伤害值
        nowHP -= atkValue;
    }

    //当前HP
    public int GetNowHP()
    {
        return nowHP;
    }


    //最大HP
    public virtual int GetMaxHP()
    {
        return maxHP;
    }

    //移动速度累计
    public virtual float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public virtual string GetAttrName()
    {
        return attrName;
    }
}
