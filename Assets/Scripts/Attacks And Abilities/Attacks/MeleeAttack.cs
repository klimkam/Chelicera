using Assets.Scripts.Attacks_And_Abilities.Attacks;
using UnityEngine;

public class MeleeAttack : Ability
{
    [SerializeField] private int _damage = 10;
    [SerializeField] private ParticleSystem _patyicleSyatem;

    [SerializeField] private Vector3 _areaOfEffectSize;
    [SerializeField] private LayerMask _enemyLayer;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
            return;
        }
        ColdownManadger();
    }
    private void Attack()
    {
        if (_coldown != 0)
        {
            return;
        }
        _patyicleSyatem.Play();
        _coldown = _coldownTime;
        Collider[] _hitEnemies = Physics.OverlapBox(transform.position, _areaOfEffectSize / 2, transform.rotation, _enemyLayer);

        foreach (Collider _enemy in _hitEnemies)
        {
            _enemy.GetComponent<BasicHealthSystem>().DealDamage(_damage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (transform == null)
            return;
        Gizmos.DrawWireCube(transform.position, _areaOfEffectSize);
    }
}
