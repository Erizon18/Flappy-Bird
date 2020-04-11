using UnityEngine;
using UnityEngine.UI;

public class Change_Score : MonoBehaviour
{
    public Text m_text;

    public void UpdateScore(int score){
        m_text.text = score.ToString();
    }
}
