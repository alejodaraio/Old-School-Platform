using UnityEngine;

namespace gamesvsalex
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]

    public class EnemyController : EnemyMotor
    {
        public int score = 0;

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}