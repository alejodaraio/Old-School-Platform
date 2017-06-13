using UnityEngine;
using UnityEngine.UI;

namespace gamesvsalex
{
    public class UIManager : MonoBehaviour
    {
        public Text score;
        public Text lives;
        public GameObject UI;

        private void Awake()
        {
            Disable();
        }

        // Update is called once per frame
        void Update()
        {
            score.text = GameTexts.SCORE_TEXT + GameManager.Instance.ScoreManager.score.ToString();
            lives.text = GameTexts.LIVES_TEXT + GameManager.Instance.LivesManager.current_lives.ToString();
        }

        public void Enable()
        {
            foreach (Transform child in UI.transform)
            {
                child.gameObject.SetActive(true);
            }
        }

        public void Disable()
        {
            foreach (Transform child in UI.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}