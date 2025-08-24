using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackRangeController : MonoBehaviour
{
    [Header("Visual Settings")]
    public bool showBorder = true;
    public Color borderColor = Color.red;
    [Range(0.01f, 0.5f)]
    public float borderThickness = 0.1f;
    [SerializeField] private float _radius;
    [SerializeField] private CircleCollider2D _circleCollider;

    private GameObject _borderObject;
    private SpriteRenderer _borderRenderer;

    private void Awake()
    {
        CreateBorderSprite();
    }

    public void Init(float radius)
    {
        SetRadius(radius);
        DrawAttackRangeCircle();
    }

    private void CreateBorderSprite()
    {
        // 테두리용 자식 오브젝트 생성
        _borderObject = new GameObject("PlayerAttackRange");
        _borderObject.transform.SetParent(transform);
        _borderObject.transform.localPosition = Vector3.zero;

        _borderRenderer = _borderObject.AddComponent<SpriteRenderer>();
        _borderRenderer.sprite = CreateCircleBorderSprite();
        _borderRenderer.color = borderColor;
        _borderRenderer.sortingOrder = 10;

        DrawAttackRangeCircle();
    }

    private void DrawAttackRangeCircle()
    {
       if (_borderObject == null || _circleCollider == null) return;

        // 콜라이더 크기에 맞춰 스프라이트 크기 조정
        float diameter = _circleCollider.radius * 2f;
        _borderObject.transform.localScale = Vector3.one * diameter;

        // 콜라이더 offset에 맞춰 위치 조정
        _borderObject.transform.localPosition = _circleCollider.offset;

        // 색상 업데이트
        if (_borderRenderer != null)
        {
            _borderRenderer.color = borderColor;
            _borderRenderer.enabled = showBorder;
        }
    }
    
    public void SetRadius(float radius)
    {
        // 실제 콜라이더 크기 바꿈
        _radius = radius;
        if (_circleCollider != null)
        {
            _circleCollider.radius = radius;
        }
        DrawAttackRangeCircle();
    }

    private Sprite CreateCircleBorderSprite()
    {
        int textureSize = 256;
        Texture2D texture = new Texture2D(textureSize, textureSize, TextureFormat.RGBA32, false);

        Vector2 center = new Vector2(textureSize / 2f, textureSize / 2f);
        float outerRadius = textureSize / 2f - 2;
        float innerRadius = outerRadius * (1f - borderThickness);

        // 투명한 배경으로 초기화
        Color[] pixels = new Color[textureSize * textureSize];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = Color.clear;
        }

        // 원형 테두리 그리기
        for (int x = 0; x < textureSize; x++)
        {
            for (int y = 0; y < textureSize; y++)
            {
                Vector2 pos = new Vector2(x, y);
                float distance = Vector2.Distance(pos, center);

                // 테두리 부분만 색칠
                if (distance <= outerRadius && distance >= innerRadius)
                {
                    pixels[y * textureSize + x] = Color.white;
                }
            }
        }

        texture.SetPixels(pixels);
        texture.Apply();

        return Sprite.Create(texture, new Rect(0, 0, textureSize, textureSize), new Vector2(0.5f, 0.5f));
    }

    // 인스펙터 변수 감지용 (개발용)
    void OnValidate()
    {
        if (Application.isPlaying)
        {
            SetRadius(_radius);
            DrawAttackRangeCircle();
        }
    }
}
