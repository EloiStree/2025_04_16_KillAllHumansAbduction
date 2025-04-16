using UnityEngine;
using UnityEngine.Events;


namespace Eloi.KillAllHumans { 
    public class OVNIMono_OnTouchEnterAction : MonoBehaviour
    {
        public LayerMask m_allowsCollision=~1;
        public UnityEvent m_onTouchAction;

        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Aie...", this.gameObject);
            m_onTouchAction.Invoke();
        }
    }

}