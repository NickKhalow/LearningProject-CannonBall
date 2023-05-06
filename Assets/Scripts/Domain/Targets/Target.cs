using DG.Tweening;
using UnityEngine;

namespace Domain.Targets
{
    [RequireComponent(typeof(Collider))]
    public class Target : AbstractTarget
    {
        [SerializeField]
        private float punchPower = 0.2f;

        private void OnCollisionEnter(Collision collision)
        {
            hit.Invoke();
            transform.DOPunchScale(Vector3.one, punchPower);
        }
    }
}