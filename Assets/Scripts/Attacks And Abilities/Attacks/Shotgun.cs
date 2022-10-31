using Assets.Scripts.Attacks_And_Abilities.Attacks;
using UnityEngine;

public class Shotgun : Ability
{
    [SerializeField] private GameObject[] _bullets;
    [SerializeField] private int _damagePerBullet;
    [SerializeField] private int _numberOfBullets;

    private void Update()
    {
        ColdownManadger();

        if (Input.GetButtonDown("Fire2")) {
            Shoot();
        }
    }

    private void Shoot() {
        if (_coldown > 0) return;
        _coldown = _coldownTime;

        for (int i = 0; i < _numberOfBullets; i++) {
            GameObject bullet = GetRandomBullet();
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    private GameObject GetRandomBullet() {

        if (_bullets.Length == 0) {
            return new GameObject();
        }
        GameObject bullet = _bullets[Random.Range(0, _bullets.Length - 1)];
        return bullet;
    }
}
