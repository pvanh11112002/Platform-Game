using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMainMenu : UICanvas
{
    public void PlayButton()
    {
        Close(0);
        MainMenuUIManager.Instance.OpenUI<CanvasGamePlay>();
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
    public void SettingButton()
    {
        MainMenuUIManager.Instance.OpenUI<CanvasSetting>();
    }
}
