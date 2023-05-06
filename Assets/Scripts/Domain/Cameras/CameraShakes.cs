using Cinemachine;
using DG.Tweening;
using UnityEngine;

namespace Domain.Cameras
{
    public class CameraShakes : MonoBehaviour
    {
        [SerializeField]
        private CinemachineVirtualCamera virtualCamera;
        [SerializeField]
        private float duration = 0.5f;
        [SerializeField]
        private AnimationCurve amplitude;
        [SerializeField]
        private AnimationCurve frequency;

        private CinemachineBasicMultiChannelPerlin component;

        private void Awake()
        {
            component = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        }

        [ContextMenu(nameof(Shake))]
        public void Shake()
        {
            float time = 0;
            DOTween.To(
                () => time,
                value =>
                {
                    time = value;
                    component.m_AmplitudeGain = amplitude.Evaluate(time);
                    component.m_FrequencyGain = frequency.Evaluate(time);
                },
                1,
                duration
            );
        }
    }
}