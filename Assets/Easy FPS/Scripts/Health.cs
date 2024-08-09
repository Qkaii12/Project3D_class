using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mau : MonoBehaviour
{
    public int maxHealthPoint;
    public Animator anim;
    public int healthPoint;
    public bool IsDead => healthPoint <= 0;
    public void Start() => healthPoint = maxHealthPoint;

    public void TakeDamage(int damage)
    {
        if (IsDead) return;

        healthPoint -= damage;
        if (IsDead)
        {
            Die();
        }
    }
    public void Die() => anim.SetTrigger("Die");
}
