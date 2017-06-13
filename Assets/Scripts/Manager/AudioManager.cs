using UnityEngine;

namespace gamesvsalex
{
    public class AudioManager : MonoBehaviour
    {
        AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void Play(AudioClip audio, float volume)
        {
            audioSource.PlayOneShot(audio, volume);
        }
    }
}