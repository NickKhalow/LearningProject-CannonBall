using UnityEngine;

namespace Domain.AxisBases
{
    public class ReducerAxisBase : AbstractAxisBase
    {
        [SerializeField]
        private AbstractAxisBase origin;
        [SerializeField]
        private Vector2 coefficient = Vector2.one;


        public override void Rotate(Vector2 angle)
        {
            origin.Rotate(angle * coefficient);
        }
    }
}