using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private MonsterStat _stat = new MonsterStat();

    public MonsterStat Stat { get { return _stat; } }

    private void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerController>();
        _stat.Init();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_player != null)
            {
                _player.TakeDamge(this);
            }
        }
    }

    private void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        if (_player == null)
            return;

        Vector2 direction = (_player.transform.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, _stat.AttackStat.MoveSpeed * Time.deltaTime);
    }
}
