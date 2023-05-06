using DG.Tweening;
using Domain.Targets;
using UnityEngine;
using UnityEngine.UI;

namespace Domain.Scores
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField]
        private Text text;
        [SerializeField]
        private AbstractTarget target;
        [SerializeField]
        private int scorePerHit = 10;
        [SerializeField]
        private int score;
        [Header("Punch")]
        [SerializeField]
        private float punchPower = 0.2f;
        [SerializeField]
        private float punchDuration = 0.1f;


        private void Awake()
        {
            target.hit.AddListener(() =>
            {
                score += scorePerHit;
                Draw();
                transform.DOPunchScale(
                    Vector3.one * punchPower,
                    punchDuration
                );
            });
            Draw();
        }

        private void Draw()
        {
            text.text = score.ToString();
        }
    }
}