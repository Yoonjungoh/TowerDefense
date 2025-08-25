using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    private PlayerAttackStat _attackStat = new PlayerAttackStat();
    private PlayerDefenseStat _defenseStat = new PlayerDefenseStat();

    public PlayerAttackStat AttackStat { get { return _attackStat; } }
    public PlayerDefenseStat DefenseStat { get {return _defenseStat; } }

    public void Init()
    {
        // TODO - 상점 강화 스탯으로 초기화
        AttackStat.Damage = 3.0f;
        AttackStat.AttackSpeed = 1.00f;
        AttackStat.CriticalRate = 1.00f;
        AttackStat.CriticalDamage = 1.20f;
        AttackStat.AttackRange = 30f;
        AttackStat.DamagePerMeter = 1.00000f;

        DefenseStat.MaxHp = 5;
        DefenseStat.Hp = DefenseStat.MaxHp;
        DefenseStat.HpRegen = 0.00f;
    }
}
