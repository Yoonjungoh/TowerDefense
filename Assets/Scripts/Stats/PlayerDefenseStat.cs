using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefenseStat : MonoBehaviour
{
    [SerializeField] private float _hp;
    [SerializeField] private float _hpRegen;

    public float hp { get { return _hp; } set { _hp = value; } }
    public float HpRegen { get { return _hpRegen; } set { _hpRegen = value; } }
}
