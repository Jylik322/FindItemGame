using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public void LoadLevel(int num)
    {
        SceneManager.LoadScene("Level " + num);
    }
}
