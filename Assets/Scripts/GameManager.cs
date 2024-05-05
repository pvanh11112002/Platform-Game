using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum GameState
{
    Play, Pause
}
public class GameManager : Singleton<GameManager>
{
    public GameState currentState;
    private void Awake()
    {
        currentState = GameState.Pause;
    }
    void Start()
    {
        MainMenuUIManager.Instance.OpenUI<CanvasMainMenu>();
    }  
}
