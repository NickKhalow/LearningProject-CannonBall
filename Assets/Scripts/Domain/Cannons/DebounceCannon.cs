using UnityEngine;

namespace Domain.Cannons
{
    public class DebounceCannon : AbstractCannon
    {
        [SerializeField]
        private AbstractCannon origin;
        [SerializeField]
        private float delay = 1;
        [Header("Debug")]
        [SerializeField]
        private float previousShot;

        public override void Shoot()
        {
            if (Time.time - delay > previousShot)
            {
                origin.Shoot();
                previousShot = Time.time;
            }
        }
    }
}