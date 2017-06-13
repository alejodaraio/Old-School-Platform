using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamesvsalex
{
    public class DestroyGameObject : MonoBehaviour
    {
        public float delay = 1f;
        
        void Update()
        {
            Destroy(gameObject, delay);
        }
    }
}