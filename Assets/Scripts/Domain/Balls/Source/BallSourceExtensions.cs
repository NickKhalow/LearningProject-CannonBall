using UnityEngine;

namespace Domain.Balls.Source
{
    public static class BallSourceExtensions
    {
        public static Ball New(
            this AbstractBallSource ballSource,
            Vector3 position,
            Quaternion rotation
        )
        {
            var ball = ballSource.New();
            ball.transform.SetPositionAndRotation(
                position,
                rotation
            );
            return ball;
        }
    }
}