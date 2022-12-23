// SceneA.
// SceneA is given the sceneName which will
// load SceneB from the Build Settings

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes: MonoBehaviour
{
  private string sceneName;
    void Start()
    {
        Debug.Log("LoadScene" );
    }

    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
