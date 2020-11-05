using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttr : ICharacterAttr
{
    protected int critRate = 0; //暴击概率

    public EnemyAttr() { }

    public EnemyAttr(int _maxHP, float _moveSpeed, int _critSpeed, string _attrName)
    {
        maxHP = _maxHP;
        nowHP = maxHP;
        moveSpeed = _moveSpeed;
        critRate = _critSpeed;
        attrName = _attrName;
    }

    //暴击率
    public int GetCritRate()
    {
        return critRate;
    }

    //减少暴击率
    public void CutdownCritRate()
    {
        critRate -= critRate / 2; 
    }
}
