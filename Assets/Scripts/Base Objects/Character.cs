using UnityEngine;

public class Character
{
    private int _health = 100;
    private bool _isAlife = true;
    
    public int Health{
        get { return _health; }
        set {
            if (!_isAlife) return;
            Debug.Log(_health);
            _health  = value;
            if (_health <= 0)
                Die();
        } 
    }

    public void DealDamage (int damage) {
        Debug.Log("Delt " + damage + " Damage");
        Health = Health - damage;
    }

    private void Die() {
        Debug.Log("I have died");
        _isAlife = false;
    }
}
