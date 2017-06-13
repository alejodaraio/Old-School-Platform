using UnityEngine;

namespace gamesvsalex
{
    public class ExitButton : MonoBehaviour, IButton
    {
        public void OnClick()
        {
            Application.Quit();

            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}