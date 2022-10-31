using UnityEngine;

namespace Assets.Scripts.Attacks_And_Abilities.Attacks
{
    public class Ability : MonoBehaviour
    {
        [SerializeField] protected float _coldownTime = 2;
        protected float _coldown = 0;

        public float CurrentColdown { get { return _coldown; } }
        public float CurrentMaxColdown { get { return _coldownTime; } }

        protected void ColdownManadger()
        {
            if (_coldown == 0)
            {
                return;
            }
            //Debug.Log(_coldown);
            if (_coldown > 0)
            {
                _coldown = _coldown - Time.deltaTime;
            }
            if (_coldown < 0.01)
            {
                _coldown = 0;
            }
        }
    }
}
