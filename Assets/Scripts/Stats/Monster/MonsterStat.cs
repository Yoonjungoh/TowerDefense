using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : MonoBehaviour
{
    private MonsterAttackStat _attackStat = new MonsterAttackStat();
    private MonsterDefenseStat _defenseStat = new MonsterDefenseStat();

    public MonsterAttackStat AttackStat { get { return _attackStat; } }
    public MonsterDefenseStat DefenseStat { get { return _defenseStat; } }

    public void Init()
    {
        // TODO - 몬스터 종류마다 스탯 초기화
        AttackStat.Damage = 1.0f;
        AttackStat.AttackSpeed = 1.00f;
        AttackStat.AttackRange = 0.8f;
        AttackStat.MoveSpeed = 0.5f;

        DefenseStat.MaxHp = 3;
        DefenseStat.Hp = DefenseStat.MaxHp;
    }
}
