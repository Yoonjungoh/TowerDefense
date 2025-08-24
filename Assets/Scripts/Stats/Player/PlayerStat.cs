using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // AttackRange는 
    // UI표시할 땐, * 37.5f 해줘야 함. 37.5는 보정 계수 (0.8에서 다음 레벨 0.013 더해주는 게 나은듯)

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
        AttackStat.AttackRange = 0.8f;
        AttackStat.DamagePerMeter = 1.00000f;

        DefenseStat.Hp = 5;
        DefenseStat.HpRegen = 0.00f;
    }
}
