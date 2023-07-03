using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerHPRenderer))]

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private int _maxHP;
    [SerializeField] private GameController _gameController;

    private int _minHP;
    private int _currentHP;
    private PlayerHPRenderer _renderer;

    private void Start()
    {
        _minHP = 0;
        _currentHP = _maxHP;
        _renderer = GetComponent<PlayerHPRenderer>();
        _renderer.SetInitialParam(_maxHP, _minHP);
        _renderer.DrowHP(_currentHP);
    }

    public void RecalculateHP(int changeHP)
    {
        _currentHP += changeHP;

        if (_currentHP > _maxHP)
            _currentHP = _maxHP;
        else if (_currentHP <= _minHP)
            Dead();

        _renderer.DrowHP(_currentHP);
    }

    private void Dead() => _gameController.ShowGameOverScreen();
}
