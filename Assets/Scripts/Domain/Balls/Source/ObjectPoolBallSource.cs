using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Domain.Balls.Source
{
    public class ObjectPoolBallSource : AbstractBallSource
    {
        [SerializeField]
        private Ball prefab;
        [SerializeField]
        private float ballLifeTime = 5f;
        private readonly Queue<Ball> balls = new();

        public override Ball New()
        {
            if (balls.TryDequeue(out var newBall))
            {
                newBall.gameObject.SetActive(true);
            }
            else
            {
                newBall = Instantiate(prefab);
            }

            StartCoroutine(CountDown(newBall));
            return newBall;
        }

        private IEnumerator CountDown(Ball ball)
        {
            yield return new WaitForSeconds(ballLifeTime);
            ball.gameObject.SetActive(false);
            balls.Enqueue(ball);
        }
    }
}