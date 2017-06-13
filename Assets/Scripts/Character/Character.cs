using System;
using UnityEngine;

namespace gamesvsalex
{
    public abstract class Character : MonoBehaviour, ICharacter
    {
        public LayerMask whatIsGround;
        public Transform groundCheck;
        public Animator m_animator;

        public AudioClip soundDeadEffect;
        public ParticleSystem deadEffect;

        protected bool m_dead = false;
        protected bool m_facingRight = true;
        protected Rigidbody2D m_rigidbody;

        float m_groundRadius = 0.2f;

        protected virtual bool isGround()
        {
            return Physics2D.OverlapCircle(groundCheck.position, m_groundRadius, whatIsGround);
        }

        protected virtual void Flip()
        {
            m_facingRight = !m_facingRight;
            Vector3 nextScale = transform.localScale;
            nextScale.x *= -1;
            transform.localScale = nextScale;
        }

        public virtual void Dead()
        {
            if (deadEffect)
            {
                ParticleSystem fx = Instantiate(deadEffect, gameObject.transform.position, Quaternion.identity);
                fx.Play();
            }

            if (soundDeadEffect)
            {
                GameManager.Instance.AudioManager.Play(soundDeadEffect, 1f);
            }

            Destroy(gameObject);
        }
    }
}