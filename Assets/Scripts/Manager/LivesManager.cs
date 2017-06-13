using UnityEngine;

namespace gamesvsalex
{
    public class LivesManager : MonoBehaviour
    {

        public const int LIVES = 3;

        [HideInInspector]
        public int current_lives = 3;

        public void Add()
        {
            current_lives += 1;
        }

        public void Remove()
        {
            current_lives -= 1;
        }

        public void Reset()
        {
            current_lives = LIVES;
        }
    }

}