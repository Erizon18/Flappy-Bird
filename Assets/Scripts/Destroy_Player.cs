using UnityEngine;

public class Destroy_Player : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player")
            other.gameObject.gameObject.GetComponent<Score>().Died();
    }
}
