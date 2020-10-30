using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private SceneStateController sceneStateController = new SceneStateController();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        //游戏初始化
        GameInit();
        sceneStateController.SetState(new StartState(sceneStateController), "");
    }

    private void GameInit()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //UnityEngine -> Update GameLoop -> StateUpdate State -> Update GameFacade(游戏系统、界面更新 InputProcess GameSystemUpdate UserInterfaceUpdate) 
        //StateController -> State -> Update -> GameFacade -> Update
        sceneStateController.StateUpdate();

        //玩家控制
        UserInput();

        //游戏逻辑更新
        UpdateGameLogic();

        //画面更新
    }

    private void UserInput()
    {

    }

    private void UpdateGameLogic()
    {

    }
}
