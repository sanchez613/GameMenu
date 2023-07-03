using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private int _damagePoints;
    [SerializeField] private PlayerHP _playerHP;

    public void Hit() => _playerHP.RecalculateHP(_damagePoints * -1);
}
