using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStat : MonoBehaviour
{
    // AttackRange�� 
    // UIǥ���� ��, * 37.5f ����� ��. 37.5�� ���� ��� (0.8���� ���� ���� 0.013 �����ִ� �� ������)

    private MonsterAttackStat _attackStat = new MonsterAttackStat();
    private MonsterDefenseStat _defenseStat = new MonsterDefenseStat();

    public MonsterAttackStat AttackStat { get { return _attackStat; } }
    public MonsterDefenseStat DefenseStat { get { return _defenseStat; } }

    public void Init()
    {
        // TODO - ���� ��ȭ �������� �ʱ�ȭ
        AttackStat.Damage = 1.0f;
        AttackStat.AttackSpeed = 1.00f;
        AttackStat.AttackRange = 0.8f;
        
        DefenseStat.Hp = 3;
    }
}
