using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHealthSystem : MonoBehaviour
{
    [SerializeField] private int _health = 0;
    [SerializeField] private int _maxHealth = 0;
    private bool _isAlife = true; 

    public int Health {
        get {
            return _health;
        }
        set
        {
            if (_isAlife)
            {
                _health = value;
                if (_health <= 0)
                {
                    Die();
                }
            }
        }
    }

    public int MaxHealth { get { return _maxHealth; } }

    public void DealDamage(int damage) {
        //Debug.Log("Delt " + damage + "Damage");
        Health -= damage;
    }

    protected virtual void Die() {
        _isAlife = false;
        //Debug.Log("I have Died");
        Destroy(gameObject);
    }
}
