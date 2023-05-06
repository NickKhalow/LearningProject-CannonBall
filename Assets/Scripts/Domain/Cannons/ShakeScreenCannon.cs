using Cinemachine;
using Domain.Cameras;
using UnityEngine;

namespace Domain.Cannons
{
    public class ShakeScreenCannon : AbstractCannon
    {
        [SerializeField]
        private AbstractCannon origin;
        [SerializeField]
        private CameraShakes cameraShakes;

        public override void Shoot()
        {
            origin.Shoot();
            if (cameraShakes)
            {
                cameraShakes.Shake();
            }
        }
    }
}