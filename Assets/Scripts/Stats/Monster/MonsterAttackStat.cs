using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttackStat : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _attackRange;
    [SerializeField] private float _moveSpeed;

    public float Damage { get { return _damage; } set { _damage = value; } }
    public float AttackSpeed { get { return _attackSpeed; } set { _attackSpeed = value; } }
    public float AttackRange { get { return _attackRange; } set { _attackRange = value; } }
    public float MoveSpeed { get { return _moveSpeed; } set { _moveSpeed = value; } }

}
