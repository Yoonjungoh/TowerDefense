using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStat _stat;
    [SerializeField] private PlayerAttackRangeController _attackRangeController;

    void Start()
    {
        _stat.Init();   // �������� ��ȭ�� ���� �Űܿ��� �κ�
        _attackRangeController.Init(_stat.AttackStat.AttackRange);  // �÷��̾��� ���� ���� ���� �׸��� �ν��ϰ� �ϴ� �κ�
    }

    void Update()
    {
        // ���� �ȿ� ���� ������ Ȯ��
        
    }
}
