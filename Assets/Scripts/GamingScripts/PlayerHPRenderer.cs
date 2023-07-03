using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlayerHPRenderer : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void SetInitialParam(int maxValue, int minValue)
    {
        _slider.maxValue = maxValue;
        _slider.value = maxValue;
        _slider.minValue = minValue;
    }

    public void DrowHP(int currentHP) => _slider.DOValue(currentHP, 0.5f);
}
