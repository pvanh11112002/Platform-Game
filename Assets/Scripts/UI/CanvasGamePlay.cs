using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasGamePlay : UICanvas
{
    private void OnEnable()
    {
        GameManager.Instance.currentState = GameState.Play;
    }
    public void SettingButton()
    {
        MainMenuUIManager.Instance.OpenUI<CanvasSetting>();
    }
}
