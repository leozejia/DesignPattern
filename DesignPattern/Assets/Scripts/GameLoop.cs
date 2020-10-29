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
        sceneStateController.SetState(new StartState(sceneStateController), "");
    }

    // Update is called once per frame
    void Update()
    {
        sceneStateController.StateUpdate();
    }
}
