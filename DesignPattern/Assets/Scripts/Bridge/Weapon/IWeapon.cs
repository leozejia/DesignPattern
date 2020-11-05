using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IWeapon
{
    //属性
    protected int atkPlusValue = 0; //额外增加的攻击力
    protected int atk = 0;          //攻击力
    protected float range = 0.0f;   //攻击距离

    //
    protected GameObject gameObject = null;  //显示的模型
    protected ICharacter weaponOwner = null;    //武器的拥有者

    //发射特效
    protected float effectDisplayTime = 0;
    protected ParticleSystem particles;
    protected LineRenderer line;
    protected AudioSource audio;
    protected Light light;

    public void SetOwner(ICharacter _weaponOwner)
    {
        weaponOwner = _weaponOwner;
    }

    public void SetAtkPlusValue(int _plusValue)
    {
        atkPlusValue = _plusValue;
    }

    public int GetAtkValue()
    {
        return atk + atkPlusValue;
    }

    public float GetAtkRange()
    {
        return range;
    }

    //显示子弹特效
    protected void ShowBulletEffect(Vector3 _targetPosition, float _lineWidth, float _displayTime)
    {
        if (line == null)
            return;
        line.enabled = true;
        line.SetWidth(_lineWidth, _lineWidth);
        line.SetPosition(0, gameObject.transform.position);
        line.SetPosition(1, _targetPosition);
        effectDisplayTime = _displayTime;
    }

    //显示枪口特效
    protected void ShowShootEffect()
    {
        if (particles != null)
        {
            particles.Stop();
            particles.Play();
        }

        if (light != null)
        {
            line.enabled = true;
        }
    }

    //播放音效
    protected void ShowSoundEffect(string _clipName)
    {
        if (audio == null)
            return;

        //获取音效
        
    }

    //攻击目标
    public void Fire(ICharacter _theTarget)
    {
        //显示武器发射/枪口特效
        ShowShootEffect();
        //显示武器子弹特效（theTarget）
        DoShowBulletEffect(_theTarget);

        //播放音效（子类实现）
        DoShowSoundEffect();

        //直接命中攻击
        _theTarget.UnderAttack(weaponOwner);
    }

    public abstract void DoShowBulletEffect(ICharacter _theTarget);

    public abstract void DoShowSoundEffect();

    public void Release()
    {

    }
}
