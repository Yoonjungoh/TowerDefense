using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStat _stat;
    [SerializeField] private PlayerAttackRangeController _attackRangeController;
    [SerializeField] private List<MonsterController> _targetList = new List<MonsterController>();

    void Start()
    {
        Init();
    }

    private void Init()
    {
        _stat.Init();   // 상점에서 강화한 스탯 옮겨오는 부분
        _attackRangeController.Init(_stat.AttackStat.AttackRange);  // 플레이어의 공격 범위 원을 그리고 인식하게 하는 부분
        _attackRangeController.OnAttackRangeTriggeredAction -= OnAttackRangeTriggeredAction;
        _attackRangeController.OnAttackRangeTriggeredAction += OnAttackRangeTriggeredAction;
    }

    public float TakeDamge(MonsterController monster)
    {
        float damage = monster.Stat.AttackStat.Damage;
        damage = Mathf.Clamp(damage, 0, damage);
        _stat.DefenseStat.Hp -= damage;
        Debug.Log($"{name}이 데미지 {damage}를 입음. 남은 체력: {_stat.DefenseStat.Hp}");
        Destroy(monster.gameObject);   // TODO
        return damage;
    }
    
    private void OnAttackRangeTriggeredAction(MonsterController monster)
    {
        _targetList.Add(monster);
        Debug.Log($"{monster.name} 추가");
    }
}
