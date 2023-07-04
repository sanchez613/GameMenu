using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int _maxHP;

    private int _minHP;
    private int _currentHP;

    public event UnityAction<int, int> SentInitialParam;
    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        _minHP = 0;
        _currentHP = _maxHP;
        SentInitialParam?.Invoke(_minHP, _maxHP);
    }

    public void RecalculateHP(int changeHP)
    {
        _currentHP += changeHP;

        if (_currentHP > _maxHP)
            _currentHP = _maxHP;
        else if (_currentHP <= _minHP)
            Died?.Invoke();

        HealthChanged?.Invoke(_currentHP);
    }

}
