using System;
using System.Collections.Generic;
using System.Text;

namespace Neon_Delivery
{
    public interface IDamageable
    {
        float CurrentHealth { get; }
        void TakeDamage(float damage);
        event System.Action onDeath;
    }
}
