using UnityEngine;

public class Score : MonoBehaviour
{
    private int scores = 0;
    private GameObject restart;
    private GameObject menu;
    private GameObject quit;
    private void Awake() {
        restart = GameObject.Find("/Canvas/Restart Button");
        menu = GameObject.Find("/Canvas/Menu Button");
        quit = GameObject.Find("/Canvas/Quit Button");
        restart.SetActive(false);
        menu.SetActive(false);
        quit.SetActive(false);

    }
    public void UpdateScore(){
        scores ++;
        GameObject.FindGameObjectWithTag("Score").GetComponent<Change_Score>().UpdateScore(scores);
    }
    public void Died()
    {
        Time.timeScale = 0;
        restart.SetActive(true);
        menu.SetActive(true);
        quit.SetActive(true);
    }
}
