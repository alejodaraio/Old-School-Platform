using UnityEngine;
namespace gamesvsalex
{
    public class SceneButton : MonoBehaviour, IButton
    {
        public GameScenes.SCENES scene;

        public void OnClick()
        {
            GameManager.Instance.SceneLoadManager.ChangeScene(GameScenes.SceneIndex(scene));
        }
    }
}