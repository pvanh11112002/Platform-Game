using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSetting : UICanvas
{
    private void OnEnable()
    {
        GameManager.Instance.currentState = GameState.Pause;
    }
    private void OnDisable()
    {
        GameManager.Instance.currentState = GameState.Play;
    }
    public void MainMenuButton()
    {
        MainMenuUIManager.Instance.CloseAll();
        MainMenuUIManager.Instance.OpenUI<CanvasMainMenu>();
    }

}
