using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDefenseStat : MonoBehaviour
{
    [SerializeField] private float _maxHp;
    [SerializeField] private float _hp;

    public float MaxHp { get { return _maxHp; } set { _maxHp = value; } }
    public float Hp { get { return _hp; } set { _hp = value; } }
}
