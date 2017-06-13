using UnityEngine;

namespace gamesvsalex
{
    public class Item : MonoBehaviour
    {
        public int value = 0;
        public AudioClip pickupEffect;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(GameTags.PLAYER))
            {
                GameManager.Instance.ScoreManager.Add(value);
                GameManager.Instance.AudioManager.Play(pickupEffect, 0.6f);
                Destroy(gameObject);
            }
        }
    }
}