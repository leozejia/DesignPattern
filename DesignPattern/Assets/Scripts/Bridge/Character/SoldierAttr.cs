using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAttr : ICharacterAttr
{
    protected int soldierLevel = 0;
    protected int addMaxHP;

    public SoldierAttr()
    {

    }

    public SoldierAttr(int _maxHP, float _moveSpeed, string _attrName)
    {
        maxHP = _maxHP;
        nowHP = maxHP;
        moveSpeed = _moveSpeed;
        attrName = _attrName;
    }

    //设置等级
    public void SetSoldierLv(int _lv)
    {
        soldierLevel = _lv;
    }

    //获取等级
    public int GetSoldierLv()
    {
        return soldierLevel;
    }

    //设置新增的最大生命力
    public void AddMaxHP(int _addMaxHP)
    {
        addMaxHP = _addMaxHP;
    }

    //最大HP
    public override int GetMaxHP()
    {
        return base.GetMaxHP()+addMaxHP;
    }
}
