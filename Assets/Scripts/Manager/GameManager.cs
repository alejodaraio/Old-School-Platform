using System.Collections;
using UnityEngine;

namespace gamesvsalex
{
    public class GameManager : Singleton<GameManager>
    {
        protected GameManager() { }

        [HideInInspector]
        public SceneLoadManager SceneLoadManager;

        [HideInInspector]
        public ScoreManager ScoreManager;

        [HideInInspector]
        public UIManager UIManager;

        [HideInInspector]
        public LivesManager LivesManager;

        [HideInInspector]
        public AudioManager AudioManager;

        public GameObject player;

        protected override void Awake()
        {
            base.Awake();

            //Instance the Managers
            SceneLoadManager = GetComponent<SceneLoadManager>();
            ScoreManager = GetComponent<ScoreManager>();
            UIManager = GetComponent<UIManager>();
            LivesManager = GetComponent<LivesManager>();
            AudioManager = GetComponent<AudioManager>();
        }

        private void Start()
        {
            StartCoroutine(GameLoop());
        }

        IEnumerator GameLoop()
        {
            while (LivesManager.current_lives > 0)
            {
                yield return null;
            }
            
            SceneLoadManager.ChangeScene(GameScenes.SceneIndex(GameScenes.SCENES.GAMEOVER));

            yield return null;
        }

        public void Restart()
        {
            SceneLoadManager.RestartScene();
        }

        void Reset()
        {
            ScoreManager.Reset();
            LivesManager.Reset();
            UIManager.Disable();

            StopAllCoroutines();
            StartCoroutine(GameLoop());
        }

        private void OnLevelWasLoaded(int level)
        {
            if(level == GameScenes.SceneIndex(GameScenes.SCENES.MAIN))
            {
                Reset();
            }
        }
    }
}