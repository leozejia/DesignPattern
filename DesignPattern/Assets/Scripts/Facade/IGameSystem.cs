//各子系统共享接口
public abstract class IGameSystem 
{
    protected GameFacade gameFacade = null;

    public IGameSystem(GameFacade _gameFacade)
    {
        gameFacade = _gameFacade;
    }

    public virtual void Initialize() { }

    public virtual void Release() { }

    public virtual void Update() { }
}
