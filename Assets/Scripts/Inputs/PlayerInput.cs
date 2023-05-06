using Domain.AxisBases;
using Domain.Cannons;
using UnityEngine;

namespace Inputs
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField]
        private AbstractCannon cannon;
        [SerializeField]
        private AbstractAxisBase axisBase;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                cannon.Shoot();
            }
            axisBase.Rotate(
                new Vector2(
                    Input.GetAxis("Horizontal"),
                    Input.GetAxis("Vertical")
                )
                * Time.deltaTime
            );
        }
    }
}