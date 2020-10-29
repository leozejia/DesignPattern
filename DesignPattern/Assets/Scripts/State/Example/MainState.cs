public class MainState : ISceneState
{
    public MainState(SceneStateController _controller) : base(_controller)
    {
        this.StateName = "MainState";
    }

    public override void StateBegin()
    {
        //Initial
    }

    public override void StateEnd()
    {
        //Release
    }

    public override void StateUpdate()
    {
        
    }
}
