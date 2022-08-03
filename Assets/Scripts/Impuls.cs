using UnityEngine;

public class Impuls : MonoBehaviour
{
    private Rigidbody m_rigidbody;
    private float _thrust = 5f;

    private void Start()
    {   
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag.Equals("redCube") && collision.gameObject.tag.Equals("blueWall"))
        {
            m_rigidbody.AddForce(_thrust, 0f, 0f, ForceMode.Impulse);
        }
        if (gameObject.tag.Equals("blueCube") && collision.gameObject.tag.Equals("redWall"))
        {
            m_rigidbody.AddForce(-_thrust, 0f, 0f, ForceMode.Impulse);
        }
    }
}
