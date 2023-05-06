using Domain.Balls;
using Domain.Balls.Source;
using UnityEngine;

namespace Domain.Cannons
{
    public class Cannon : AbstractCannon
    {
        [SerializeField]
        private float power;
        [SerializeField]
        private AbstractBallSource abstractBallSource;
        [SerializeField]
        private Transform shootPoint;


        [ContextMenu(nameof(Shoot))]
        public override void Shoot()
        {
            abstractBallSource.New(
                shootPoint.position,
                shootPoint.rotation
            ).Apply(
                shootPoint.forward * power
            );
        }
    }
}