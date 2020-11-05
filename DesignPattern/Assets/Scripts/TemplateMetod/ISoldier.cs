using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ISoldier : ICharacter
{
    public override void UnderAttack(ICharacter _attacker)
    {
        //被武器攻击
        attribute.CalDmgValue(_attacker);

        //是否阵亡
        if (attribute.GetNowHP() <= 0)
        {
            DoPlayKilledSound();
            DoShowKilledEffect();
            Killed();
        }
    }

    public abstract void DoPlayKilledSound();

    public abstract void DoShowKilledEffect();

    public abstract void Killed();
}
