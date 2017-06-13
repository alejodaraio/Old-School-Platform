using UnityEngine;

namespace gamesvsalex
{
    public class PlayerAttack : MonoBehaviour
    {
        public float rebound = 10f;

        Character m_player;
        Rigidbody2D m_rigidbody;

        private void Awake()
        {
            m_player = GetComponent<Character>();
            m_rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            switch (collision.tag)
            {
                case GameTags.ENEMY:

                    Vector2 from = new Vector2(0, gameObject.transform.position.y);
                    Vector2 target = new Vector2(0, collision.gameObject.transform.position.y);

                    bool hit = HitChecker(from, target, 0.5f);

                    if (hit)
                    {
                        Hit(collision);
                    }
                    else
                    {
                        m_player.Dead();
                    }

                    break;
            }
        }

        private void Hit(Collider2D collision)
        {
            m_rigidbody.AddForce(Vector2.up * rebound, ForceMode2D.Impulse);

            EnemyController target = collision.gameObject.GetComponent<EnemyController>();

            GameManager.Instance.ScoreManager.Add(target.score);

            target.Dead();
        }

        bool HitChecker(Vector2 from, Vector2 target, float margin)
        {
            float distance = Vector2.Distance(from, target);
            return (distance > margin);
        }
    }
}