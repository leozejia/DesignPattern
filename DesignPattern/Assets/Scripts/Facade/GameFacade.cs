using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade
{
    private static GameFacade _instance = null;
    public static GameFacade Instante
    {
        get
        {
            if (_instance == null)
                _instance = new GameFacade();
            return _instance;
        }
    }

    private GameFacade()
    { }
}
