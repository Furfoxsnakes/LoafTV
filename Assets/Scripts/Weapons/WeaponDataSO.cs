using UnityEngine;

namespace Weapons {
    [CreateAssetMenu(fileName = "Weapon Data", menuName = "Weapons/Weapon Data", order = 0)]
    public class WeaponDataSO : ScriptableObject {
        public float ShotsPerSecond = 1f;
        public Projectile Projectile;
        public float ProjectileSpeed = 1f;
        public float BaseDamage = 1f;
    }
}