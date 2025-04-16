using UnityEngine;
using UnityEngine.Events;

public class ArgMono : MonoBehaviour
{
    public UnityEvent m_onTouchAction;

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Aie...", this.gameObject);
        m_onTouchAction.Invoke();
    }
}
