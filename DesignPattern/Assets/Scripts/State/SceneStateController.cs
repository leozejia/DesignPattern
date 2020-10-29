using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState sceneState = null;
    private bool runBegin = false;
    private AsyncOperation sceneAsync = null;

    public void SetState(ISceneState _sceneState, string _sceneName)
    {
        runBegin = false;

        LoadScene(_sceneName);

        //如果当前有状态，则通知它结束
        if (sceneState != null)
            sceneState.StateEnd();

        sceneState = _sceneState;
    }

    private void LoadScene(string sceneName)
    {
        if (sceneName == null || sceneName.Length == 0)
            return;
        sceneAsync = SceneManager.LoadSceneAsync(sceneName);
    }

    public void StateUpdate()
    {
        if (sceneAsync !=null&& !sceneAsync.isDone)
            return;
        //else
        //    sceneAsync.allowSceneActivation = true;
        if (sceneState != null&&runBegin==false)
        {
            sceneState.StateBegin();
            runBegin = true;
        }

        if (sceneState != null)
        {
            sceneState.StateUpdate();
        }
    }
}
