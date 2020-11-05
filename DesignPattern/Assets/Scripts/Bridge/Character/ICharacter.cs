using UnityEngine;
using System.Collections;

public abstract class ICharacter
{
    protected string name = ""; //名称
    protected GameObject gameObject = null; //显示的unity模型
    protected NavMeshAgent navAgent = null; //用于控制角色移动
    protected AudioSource audio = null;
    protected string iconSpriteName = "";   //显示icon

    protected bool bKilled = false; //是否阵亡
    protected bool bCheckKilled = false;
    protected float removeTimer = 1.5f;
    protected bool bCanRemove = false;

    private IWeapon weapon = null;
    protected ICharacterAttr attribute = null;  //角色属性

    public ICharacter()
    {
    }
    //设置角色属性
    public virtual void SetCharacterAttr(ICharacterAttr _characterAttr)
    {
        //设置
        attribute = _characterAttr;
        attribute.InitAttr();

        //设置移动速度
        navAgent.speed = attribute.GetMoveSpeed();

        //名称
        name = attribute.GetAttrName();
    }

    //设置Unity模型
    public void SetGameObject(GameObject _gameObject)
    {
        gameObject = _gameObject;
        navAgent = gameObject.GetComponent<NavMeshAgent>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    //获取Unity模型
    public GameObject GetGameObject()
    {
        return gameObject;
    }

    //释放
    public void Release()
    {
        if (gameObject != null)
            GameObject.Destroy(gameObject);
    }

    //名称
    public string GetName()
    {
        return name;
    }

    //设置Icon名称
    public void SetIconSpriteName(string _spriteName)
    {
        iconSpriteName = _spriteName;
    }

    //获取icon名称
    public string GetIconSpriteName()
    {
        return iconSpriteName;
    }

    //设置武器
    public void SetWeapon(IWeapon _weapon)
    {
        if (weapon != null)
            weapon.Release();
        weapon = _weapon;

        //设置武器拥有者
        weapon.SetOwner(this);

        //设置unity gameobject的层级
        //UnityTool.Attach(_gameObject,_weapon.GetGameObject(),Vector3.zero);
    }

    public IWeapon GetWeapon()
    {
        return weapon;
    }

    //设置额外攻击力
    protected void SetWeaponAtkPlusValue(int _value)
    {
        weapon.SetAtkPlusValue(_value);
    }

    //武器攻击目标
    protected void WeaponAttackTarget(ICharacter _target)
    {
        weapon.Fire(_target);
    }

    //计算攻击力
    public int GetAtkValue()
    {
        //武器攻击力+角色属性的加成
        return weapon.GetAtkValue();
    }

    //获取攻击距离
    public float GetAttackRange()
    {
        return weapon.GetAtkRange();
    }

    //攻击目标
    public void Attack(ICharacter _target)
    {
        //设置额外攻击力
        weapon.SetAtkPlusValue(attribute.GetAtkPlusValue());

        //使用武器攻击目标
        weapon.Fire(_target);
    }

    //被其他角色攻击
    public abstract void UnderAttack(ICharacter _attacker);
    //{
    //    //计算伤害值
    //    attribute.CalDmgValue(_attacker);

    //    //是否阵亡
    //    if (attribute.GetNowHP() <= 0)
    //    {
    //        Debug.Log("角色死亡");
    //    }
    //}
}
