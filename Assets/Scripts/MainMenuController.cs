using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    enum Screen
    {
        MainMenu,
        LevelsMenu,
        SettingsMenu
    }

    [SerializeField] private CanvasGroup _levelsMenu;
    [SerializeField] private CanvasGroup _mainMenu;
    [SerializeField] private CanvasGroup _settingsMenu;
    void Start()
    {
        SetCanvasGroup(Screen.MainMenu);
    }

    void SetCanvasGroup(Screen screen)
    {
        CanvasGroup(_levelsMenu, screen == Screen.LevelsMenu);
        CanvasGroup(_mainMenu,screen == Screen.MainMenu);
        CanvasGroup(_settingsMenu,screen == Screen.SettingsMenu);
    }
    void CanvasGroup(CanvasGroup @group, bool value)
    {
        @group.alpha = value ? 1 : -1;
        @group.interactable = value;
        @group.blocksRaycasts = value;
    }

    public void Play() =>
        SetCanvasGroup(Screen.LevelsMenu);
    public void Settings() =>
        SetCanvasGroup(Screen.SettingsMenu);
    public void MainMenu() =>
        SetCanvasGroup(Screen.MainMenu);
    public void Level1() =>
        SceneManager.LoadScene("Level-1");
    public void Level2() =>
        SceneManager.LoadScene("Level-2");

}
