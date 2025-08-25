using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackRangeController : MonoBehaviour
{
    private float _radius;
    private float _correctionFactor = 6.0f;

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
