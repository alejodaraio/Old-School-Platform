using UnityEngine;

namespace gamesvsalex
{
    public class LevelManager : MonoBehaviour
    {
        private void OnLevelWasLoaded(int level)
        {
            GameManager.Instance.UIManager.Enable();
            SpawmPlayer();
        }

        void SpawmPlayer()
        {
            Vector3 spawnPosition = GameObject.FindGameObjectWithTag(GameTags.SPAWN).transform.position;
            Instantiate(GameManager.Instance.player, spawnPosition, Quaternion.identity);
        }
    }
}