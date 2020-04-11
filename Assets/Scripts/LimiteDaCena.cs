using UnityEngine;

public class LimiteDaCena : MonoBehaviour
{
    private BoxCollider2D m_boxCollider;
    void Awake()
    {
        m_boxCollider = GetComponent<BoxCollider2D>();
        if (!m_boxCollider.isTrigger)
            m_boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        other.gameObject.GetComponent<Score>().Died();
    }
}
