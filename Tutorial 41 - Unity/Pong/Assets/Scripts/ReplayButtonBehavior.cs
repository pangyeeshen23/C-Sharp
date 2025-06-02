using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtonBehavior : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Game");
    }
}
