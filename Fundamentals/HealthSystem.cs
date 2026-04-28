using Neon_Delivery;

namespace Fundamentals
{
    public class HealthSystem : IDamageable
    {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }

        public event Action OnDeath;
        public HealthSystem(float MaxHealth) 
        {
            this.MaxHealth = MaxHealth;
            CurrentHealth = MaxHealth;
        }
        public void TakeDamage(float damage)
        {
            CurrentHealth -= damage;
            if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
                OnDeath?.Invoke();
            }
        }
        public void Heal(float amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }
    }
}
