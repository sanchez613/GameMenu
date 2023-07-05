using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerHPRenderer : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _drowDuration;
    [SerializeField] private PlayerHP _playerHP;

    private void OnEnable()
    {
        _playerHP.SentInitialParam += OnSentInitialParam;        
        _playerHP.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _playerHP.SentInitialParam -= OnSentInitialParam;
        _playerHP.HealthChanged -= OnHealthChanged;
    }

    public void OnSentInitialParam(int minValue, int maxValue)
    {
        _slider.maxValue = maxValue;
        _slider.value = maxValue;
        _slider.minValue = minValue;
    }

    public void OnHealthChanged(int currentHP) => _slider.DOValue(currentHP, _drowDuration);
}
