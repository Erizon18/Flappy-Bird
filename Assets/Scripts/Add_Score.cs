using UnityEngine;

public class Add_Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player")
            other.gameObject.GetComponent<Score>().UpdateScore();
    }
}
