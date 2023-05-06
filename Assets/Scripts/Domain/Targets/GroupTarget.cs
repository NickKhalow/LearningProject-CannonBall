using UnityEngine;

namespace Domain.Targets
{
    public class GroupTarget : AbstractTarget
    {
        [SerializeField]
        private AbstractTarget[] targets;

        private void Awake()
        {
            foreach (var abstractTarget in targets)
            {
                abstractTarget.hit.AddListener(hit.Invoke);
            }
        }
    }
}