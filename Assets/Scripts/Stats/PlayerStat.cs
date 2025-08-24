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
    }
}
