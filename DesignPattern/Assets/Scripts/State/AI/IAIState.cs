using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IAIState
{
    //角色AI
    protected ICharacterAI characterAI = null;

    public IAIState() { }

    //设置CharacterAI的对象
    public void SetCharacterAI(ICharacterAI _characterAI)
    {
        characterAI = _characterAI;
    }

    //设置要攻击的对象
    public virtual void SetAttackPosition(Vector3 _attackPosition)
    {
    }

    //更新
    public abstract void Update(List<ICharacter> _targets);

    //目标被删除
    public virtual void RemoveTarget(ICharacter _target)
    { }
}
