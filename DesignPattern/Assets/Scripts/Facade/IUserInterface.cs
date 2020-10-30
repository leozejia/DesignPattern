using UnityEngine;
using System.Collections;

public abstract class IUserInterface
{
    protected GameFacade gameFacade = null;
    protected GameObject rootUI = null;
    private bool bActive = true;
    public IUserInterface(GameFacade _gameFacade)
    {
        gameFacade = _gameFacade;
    }

    public bool IsVisible()
    {
        return bActive;
    }

    public virtual void Show()
    {
        rootUI.SetActive(true);
        bActive = true;
    }

    public virtual void Hide()
    {
        rootUI.SetActive(false);
        bActive = false;
    }

    public virtual void Initialize(){}

    public virtual void Release() { }

    public virtual void Update() { }
}
