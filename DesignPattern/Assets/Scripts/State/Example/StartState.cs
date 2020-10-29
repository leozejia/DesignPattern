public class StartState : ISceneState
{
    public StartState(SceneStateController _controller) : base(_controller)
    {
        this.StateName = "StartState";
    }

    public override void StateBegin()
    {
        //用来初始化参数
    }

    public override void StateEnd()
    {
        
    }

    public override void StateUpdate()
    {
        controller.SetState(new MainState(controller),"MainScene");
    }
}