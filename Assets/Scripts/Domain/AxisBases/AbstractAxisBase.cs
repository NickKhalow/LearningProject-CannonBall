using UnityEngine;

namespace Domain.AxisBases
{
    public abstract class AbstractAxisBase : MonoBehaviour
    {
        public abstract void Rotate(Vector2 vector);
    }
}