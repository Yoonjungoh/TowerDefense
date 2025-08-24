using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // AttackRange�� 
    // UIǥ���� ��, * 37.5f ����� ��. 37.5�� ���� ��� (0.8���� ���� ���� 0.013 �����ִ� �� ������)

    private PlayerAttackStat _attackStat = new PlayerAttackStat();
    private PlayerDefenseStat _defenseStat = new PlayerDefenseStat();

    public PlayerAttackStat AttackStat { get { return _attackStat; } }
    public PlayerDefenseStat DefenseStat { get {return _defenseStat; } }

    public void Init()
    {
        // TODO - ���� ��ȭ �������� �ʱ�ȭ
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
