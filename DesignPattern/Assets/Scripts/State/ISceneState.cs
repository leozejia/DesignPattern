public abstract class ISceneState
{
    //状态名称
    private string stateName = "ISceneState";
    public string StateName
    {
        get
        {
            return stateName;
        }
        set
        {
            stateName = value;
        }
    }

    //控制者
    protected SceneStateController controller = null;
    //构造函数
    public ISceneState(SceneStateController _controller)
    {
        controller = _controller;
    }

    /// <summary>
    /// 状态开始
    /// </summary>
    public abstract void StateBegin();

    /// <summary>
    /// 状态结束
    /// </summary>
    public abstract void StateEnd();

    /// <summary>
    /// 状态更新
    /// </summary>
    public abstract void StateUpdate();

    public override string ToString()
    {
        return string.Format("[ISceneState:StateName={0}]", stateName);
    }
}
