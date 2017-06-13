using UnityEngine;

namespace gamesvsalex
{
    public abstract class PlayerMotor : Character, ICharacterMove, ICharacterJump
    {
        public float speed = 3f;
        public float jumpForce = 30f;

        public virtual void Move()
        {
            float horizontal = Input.GetAxis(GameInputs.HORIZONTAL);

            //Flip the sprite according direction
            if (horizontal > 0 && !m_facingRight || horizontal < 0 && m_facingRight)
            {
                Flip();
            }

            //set the current speed for the animator
            m_animator.SetFloat("speed", Mathf.Abs(horizontal));

            //apply the velocity to move the player
            m_rigidbody.velocity = new Vector2(horizontal * speed, m_rigidbody.velocity.y);
        }

        public virtual void Jump()
        {
            if (isGround())
            {
                m_rigidbody.AddForce(Vector2.up * jumpForce * 10f);
            }                
        }

        public override void Dead()
        {
            base.Dead();

            GameManager.Instance.LivesManager.Remove();
     
            GameManager.Instance.Restart();
        }
    }
}