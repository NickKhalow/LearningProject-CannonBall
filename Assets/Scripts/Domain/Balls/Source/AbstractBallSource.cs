using UnityEngine;

namespace Domain.Balls.Source
{
    public abstract class AbstractBallSource : MonoBehaviour
    {
        public abstract Ball New();
    }
}