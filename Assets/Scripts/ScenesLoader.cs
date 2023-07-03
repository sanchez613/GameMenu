using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class ScenesLoader : MonoBehaviour
{
    [SerializeField] private LevelConfig _levelConfig;

    public void LoadGame()
    {
        Game.Load(_levelConfig);
    }

    public void LoadMainMenu()
    {
        MainMenu.Load();
    }
}
