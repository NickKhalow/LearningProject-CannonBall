using UnityEngine;

namespace Domain.AxisBases
{
    public class AxisBase : AbstractAxisBase
    {
        [SerializeField]
        private Transform axis;
        [SerializeField]
        private Vector2 current;

        public Vector2 Current => current;

        private void Awake()
        {
            Apply();
        }

        private void Apply()
        {
            axis.rotation = Quaternion.Euler(current.y, current.x, 0);
        }

        public override void Rotate(Vector2 vector)
        {
            current += vector;
            Apply();
        }
    }
}