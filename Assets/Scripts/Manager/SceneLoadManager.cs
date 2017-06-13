using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour {

    public GameObject loadScreen;

    float m_loadScreenDelay = 1f;
   
    public void ChangeScene(int scene)
    {
        StartCoroutine(LoadScene(scene));
    }

    public void RestartScene()
    {
        ChangeScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator LoadScene(int scene)
    {
        loadScreen.SetActive(true);

        yield return new WaitForSeconds(m_loadScreenDelay);

        SceneManager.LoadScene(scene);

        yield return null;
    }

    private void OnLevelWasLoaded(int level)
    {
        loadScreen.SetActive(false);
    }
}