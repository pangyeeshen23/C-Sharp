using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public string sceneName;

    public void OnButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
