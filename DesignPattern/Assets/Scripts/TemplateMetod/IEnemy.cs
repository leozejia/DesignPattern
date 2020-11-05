using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IEnemy : ICharacter
{
    public override void UnderAttack(ICharacter _attacker)
    {
        //被武器攻击
        attribute.CalDmgValue(_attacker);

        DoPlayHitSound();   //音效

        DoShowHitEffect();  //显示特效

        if (attribute.GetNowHP() <= 0)
            Killed();
    }

    public abstract void DoPlayHitSound();

    public abstract void DoShowHitEffect();

    public abstract void Killed();
}
