using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int maxHealthPoint;
    public UnityEvent onDie;
    public UnityEvent<int, int> onHealthChanged;
    public int _healthPointValue;
    public int healthPoint
    {
        get => _healthPointValue;
        set
        {
            _healthPointValue = value;
            onHealthChanged.Invoke(_healthPointValue, maxHealthPoint);
        }
    }

    private bool IsDead => healthPoint <= 0;
    private void Start() => healthPoint = maxHealthPoint;
    public void TakeDamage(int damage)
    {
        if (IsDead) return;
        healthPoint -= damage;
        if (IsDead)
        {
            Die();
        }
    }
    private void Die() => onDie.Invoke();
}
