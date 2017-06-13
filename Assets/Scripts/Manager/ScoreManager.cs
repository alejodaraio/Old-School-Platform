using UnityEngine;
using System.Collections;

namespace gamesvsalex
{
    public class ScoreManager : MonoBehaviour
    {
        public int score { get; set; }

        public void Add(int value)
        {
            score += value;
        }

        public void Reset()
        {
            score = 0;
        }
    }
}