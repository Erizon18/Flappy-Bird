using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour
{
    public void Change(string scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        if(!UnityEditor.EditorApplication.isPlaying)
            Application.Quit();
        else
            UnityEditor.EditorApplication.isPlaying = false;
    }
}
