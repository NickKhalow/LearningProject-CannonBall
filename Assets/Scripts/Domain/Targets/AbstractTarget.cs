using UnityEngine;
using UnityEngine.Events;

namespace Domain.Targets
{
    public class AbstractTarget : MonoBehaviour
    {
        public UnityEvent hit = new();
    }
}