using UnityEngine;

public class Destroy_Canos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "cano")
        {
            other.gameObject.GetComponent<Movimento_cano>().DestroyZone();
        }  
    }
}
