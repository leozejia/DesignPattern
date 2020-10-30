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

    public ICharacter()
    {
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
}
