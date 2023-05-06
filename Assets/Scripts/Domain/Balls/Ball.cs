using UnityEngine;

namespace Domain.Balls
{
    [RequireComponent(typeof(Rigidbody))]
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody body;

        public void Apply(Vector3 force)
        {
            body.AddForce(force, ForceMode.VelocityChange);
        }

        private void OnEnable()
        {
            body.velocity = Vector3.zero;
        }
    }
}