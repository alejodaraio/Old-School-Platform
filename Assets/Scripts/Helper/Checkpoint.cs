using UnityEngine;

namespace gamesvsalex
{
    public class Checkpoint : MonoBehaviour
    {
        public GameScenes.SCENES level;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            GameManager.Instance.SceneLoadManager.ChangeScene(GameScenes.SceneIndex(level));
        }
    }
}