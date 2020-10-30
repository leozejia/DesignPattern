public class MainState : ISceneState
{
    public MainState(SceneStateController _controller) : base(_controller)
    {
        this.StateName = "MainState";
    }

    public override void StateBegin()
    {
        //Initial
        GameFacade.Instance.Initial();
    }

    public override void StateEnd()
    {
        //Release
        GameFacade.Instance.Release();
    }

    public override void StateUpdate()
    {
        GameFacade.Instance.Update();
    }
}
