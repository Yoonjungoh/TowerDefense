using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStat _stat;
    [SerializeField] private PlayerAttackRangeController _attackRangeController;

    void Start()
    {
        _stat.Init();   // 상점에서 강화한 스탯 옮겨오는 부분
        _attackRangeController.Init(_stat.AttackStat.AttackRange);  // 플레이어의 공격 범위 원을 그리고 인식하게 하는 부분
    }

    void Update()
    {
        // 범위 안에 적이 들어오나 확인
        
    }
}
