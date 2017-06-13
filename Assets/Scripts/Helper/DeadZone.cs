using UnityEngine;

namespace gamesvsalex
{
    public class DeadZone : MonoBehaviour
    {
        GameObject target;

        private void Start()
        {
            target = GameObject.FindGameObjectWithTag(GameTags.PLAYER);
        }

        void Update()
        {
            if(target != null)
                transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.CompareTag(GameTags.PLAYER))
            {
                collision.gameObject.GetComponent<Character>().Dead();
            }
        }
    }
}