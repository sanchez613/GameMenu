using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IJunior.TypedScenes;

public class GameController : MonoBehaviour, ISceneLoadHandler<LevelConfig>
{
    [SerializeField] private DeathScreen _deathScreen;
    [SerializeField] private GameScreen _gameScreen;
    [SerializeField] private PauseScreen _pauseScreen;
    [SerializeField] private AudioSource _backgroundMusic;
    [SerializeField] private Slider _volumeSlider;
    [SerializeField] private PlayerHP _playerHP;

    private void OnEnable()
    {
        _playerHP.Died += ShowGameOverScreen;
    }

    private void OnDisable()
    {
        _playerHP.Died -= ShowGameOverScreen;
    }

    public void ShowGameOverScreen()
    {
        _deathScreen.gameObject.SetActive(true);
        _gameScreen.gameObject.SetActive(false);
    }

    public void UnPause()
    {
        _pauseScreen.gameObject.SetActive(false);
        _gameScreen.gameObject.SetActive(true);
    }

    public void Pause()
    {
        _pauseScreen.gameObject.SetActive(true);
        _gameScreen.gameObject.SetActive(false);
    }

    public void OnSceneLoaded(LevelConfig argument)
    {
        _backgroundMusic.volume = argument.Volume;
        _volumeSlider.value = argument.Volume;
    }
}