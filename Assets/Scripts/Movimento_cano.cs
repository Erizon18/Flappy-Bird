using UnityEngine;

public class Movimento_cano : MonoBehaviour
{
    private float speed = 3;
    private Transform m_transform;
    void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    public void DestroyZone()
    {
        Destroy(gameObject);
    }
}
