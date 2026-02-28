using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoints = 100f;
        
        bool _isDead = false;

        public bool IsDead()
        {
            return _isDead;
        }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max( healthPoints - damage, 0);
            if (healthPoints <= 0)
            {
               Die(); 
            }
        }

        private void Die()
        {
            if (_isDead) return;
            
            _isDead = true;
            // ReSharper disable once Unity.PreferAddressByIdToGraphicsParams
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}