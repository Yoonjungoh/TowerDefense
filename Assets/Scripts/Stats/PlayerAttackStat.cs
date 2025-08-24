using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackStat : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _criticalRate;
    [SerializeField] private float _criticalDamage;
    [SerializeField] private float _damagePerMeter; // 적이 타워에서 멀어질수록 데미지 증가
    
    public float Damage { get { return _damage; } set { _damage = value; } }
    public float AttackSpeed { get { return _attackSpeed; } set { _attackSpeed = value; } }
    public float CriticalRate { get { return _criticalRate; } set { _criticalRate = value; } }
    public float CriticalDamage { get { return _criticalDamage; } set { _criticalDamage = value; } }
    public float DamagePerMeter { get { return _damagePerMeter; } set { _damagePerMeter = value; } }

}
