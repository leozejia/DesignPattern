using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 系统Facade，存储所有子系统
/// </summary>
public class GameFacade
{
    private static GameFacade _instance = null;
    public static GameFacade Instance
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

    private bool bGameOver = false;

    //游戏系统
    private GameEventSystem gameEventSystem = null; //游戏事件系统
    private CampSystem campSystem = null;   //兵营系统
    private StageSystem stageSystem = null; //关卡系统
    private CharacterSystem characterSystem = null; //角色管理系统
    private APSystem apSystem = null;   //行动力系统
    private AchievementSystem achievementSystem = null;

    //界面
    private CampInfoUI campInfoUI = null;
    private SoldierInfoUI soldierInfoUI = null;
    private GameStateInfoUI gameStateInfoUI = null;
    private GamePauseUI gamePauseUI = null;

    public void Initial()
    {
        bGameOver = false;

        //游戏系统
        gameEventSystem = new GameEventSystem(this);
        campSystem = new CampSystem(this);
        stageSystem = new StageSystem(this);
        characterSystem = new CharacterSystem(this);
        apSystem = new APSystem(this);
        achievementSystem = new AchievementSystem(this);

        //界面
        campInfoUI = new CampInfoUI(this);
        soldierInfoUI = new SoldierInfoUI(this);
        gameStateInfoUI = new GameStateInfoUI(this);
    }

    public void Release()
    {
        //释放资源

    }

    public void RegisterGameEvent()
    {

    }

    //更新
    public void Update()
    {
        InputProcess();

        //游戏系统更新
        gameEventSystem.Update();
        campSystem.Update();
        stageSystem.Update();
        characterSystem.Update();
        apSystem.Update();
        achievementSystem.Update();

        //界面更新
        campInfoUI.Update();
        soldierInfoUI.Update();
        gameStateInfoUI.Update();
        gamePauseUI.Update();
    }

    /// <summary>
    /// 玩家输入
    /// </summary>
    public void InputProcess()
    {

    }
}