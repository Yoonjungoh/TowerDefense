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
        _stat.Init();   // �������� ��ȭ�� ���� �Űܿ��� �κ�
        _attackRangeController.Init(_stat.AttackStat.AttackRange);  // �÷��̾��� ���� ���� ���� �׸��� �ν��ϰ� �ϴ� �κ�
        _attackRangeController.OnAttackRangeTriggeredAction -= OnAttackRangeTriggeredAction;
        _attackRangeController.OnAttackRangeTriggeredAction += OnAttackRangeTriggeredAction;
    }

    public float TakeDamge(MonsterController monster)
    {
        float damage = monster.Stat.AttackStat.Damage;
        damage = Mathf.Clamp(damage, 0, damage);
        _stat.DefenseStat.Hp -= damage;
        Debug.Log($"{name}�� ������ {damage}�� ����. ���� ü��: {_stat.DefenseStat.Hp}");
        Destroy(monster.gameObject);   // TODO
        return damage;
    }
    
    private void OnAttackRangeTriggeredAction(MonsterController monster)
    {
        _targetList.Add(monster);
        Debug.Log($"{monster.name} �߰�");
    }
}
