using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDefenseStat : MonoBehaviour
{
    [SerializeField] private float _hp;

    public float Hp { get { return _hp; } set { _hp = value; } }
}
