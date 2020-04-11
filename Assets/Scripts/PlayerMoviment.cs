using UnityEngine;

namespace Teste_Movimentacao
{
    public class PlayerMoviment : MonoBehaviour
    {
        private float SPEED = 0.0f;
        public  float jumpHeight = 2f;
        private Rigidbody2D m_rb;
        private Transform m_transform;


        void Awake()
        {
            m_rb = GetComponent<Rigidbody2D>();
            m_transform = GetComponent<Transform>();
        }
        void Update()
        {
            //Moviment();
            Jump();
            Rotate();
        }

        public void Moviment()
        {
            if (Input.GetKey(KeyCode.D))
            {
                m_rb.AddForce(Vector2.right * SPEED);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                m_rb.AddForce(Vector2.left * SPEED);
            }
        }

        public void Jump()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                m_rb.AddForce(Vector2.up * jumpHeight);
            }
        }

        private void Rotate(){
            if(m_rb.velocity.y * 5 < 45 || m_rb.velocity.y * 5 > - 45)
                m_transform.rotation = Quaternion.Euler(0,0,m_rb.velocity.y * 5);
        }
    }
}
