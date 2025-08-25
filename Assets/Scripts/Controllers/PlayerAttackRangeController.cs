using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackRangeController : MonoBehaviour
{
    private float _radius;
    private float _correctionFactor = 6.0f;

    public Action<MonsterController> OnAttackRangeTriggeredAction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            MonsterController monster = collision.GetComponent<MonsterController>();
            if (monster != null)
            {
                OnAttackRangeTriggeredAction?.Invoke(monster);
            }
        }
    }

    public void Init(float radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(float radius)
    {
        _radius = radius;
        DrawAttackRange();
    }

    private void DrawAttackRange()
    {
        transform.localScale = new Vector3(_radius / _correctionFactor, _radius / _correctionFactor, 0);
    }
}
