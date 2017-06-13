using UnityEngine;

namespace gamesvsalex
{
    public abstract class EnemyMotor : Character, ICharacterMove
    {
        public float speed = 2f;
        float horizontal = 1f;
        float vertical;

        private void Awake()
        {
            vertical = m_rigidbody.velocity.y;
        }

        public virtual void Move()
        {
            //Flip the sprite according direction
            if (horizontal > 0 && !m_facingRight || horizontal < 0 && m_facingRight)
            {
                Flip();
            }

            //apply the velocity to move the player
            m_rigidbody.velocity = new Vector2(horizontal * speed, vertical);
        }

        public override void Dead()
        {
            base.Dead();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Patrol(collision);
        }

        private void Patrol(Collider2D collision)
        {
            if (collision.transform.CompareTag(GameTags.PATROL_LIMIT))
            {
                horizontal *= -1;
            }
        }
    }
}