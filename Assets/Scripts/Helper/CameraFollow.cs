using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gamesvsalex
{
    public class CameraFollow : MonoBehaviour
    {
        public GameObject target;
        public float smooth = 10f;

        private void Start()
        {
            target = GameObject.FindGameObjectWithTag(GameTags.PLAYER);
        }

        private void LateUpdate()
        {
            Follow();
        }

        void Follow()
        {
            if(target != null)
            {
                Vector3 currentTargetPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
                Vector3 position = Vector3.Lerp(transform.position, currentTargetPosition, smooth * Time.deltaTime);
                transform.position = position;
            }
        }
    }
}