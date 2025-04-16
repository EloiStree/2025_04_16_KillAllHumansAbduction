using UnityEngine;

public class BonjourRotation : MonoBehaviour
{
    public float m_rotationSpeed = 720;
    public bool m_inverse = false;
    void Update()
    {
        if (m_inverse)
            transform.Rotate(0, 0, -m_rotationSpeed * Time.deltaTime, Space.Self);
        else 
            transform.Rotate(0, 0, m_rotationSpeed * Time.deltaTime, Space.Self);

    }
    void Start()
    {
        Debug.Log("Hello World");
    }
    private void OnEnable()
    {

        Debug.Log("Tu me vois...");
    }
    private void OnDisable()
    {

        Debug.Log("Tu me vois plus...");
    }

  
}
