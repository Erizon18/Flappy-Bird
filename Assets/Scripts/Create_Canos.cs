using UnityEngine;

public class Create_Canos : MonoBehaviour
{
    public GameObject objectToCreate;
    public float timeToCreate = 2f;
    private float timeLeftToCreate;
    private Transform m_trasform;

    private void Awake() 
    {
        m_trasform = GetComponent<Transform>();
        timeLeftToCreate = timeToCreate;
    }
    void Update()
    {
        if (timeLeftToCreate <= 0)
        {
            timeLeftToCreate = timeToCreate;
            Instantiate(objectToCreate,m_trasform.position + new Vector3(0,Random.Range(0.7f,5f),0),m_trasform.rotation);
        }
        else
            timeLeftToCreate -= Time.deltaTime;
    }
}
