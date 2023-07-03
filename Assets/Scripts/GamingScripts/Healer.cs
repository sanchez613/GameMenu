using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private int _healingPoints;
    [SerializeField] private PlayerHP _playerHP;

    public void Healing() => _playerHP.RecalculateHP(_healingPoints);
}
