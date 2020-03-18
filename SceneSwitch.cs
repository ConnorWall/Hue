using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Begin");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Begin");
    }
}
