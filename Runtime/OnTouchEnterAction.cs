using UnityEngine;
using UnityEngine.Events;


namespace Eloi.KillAllHumans { 
    public class OnTouchEnterAction : MonoBehaviour
    {
        public UnityEvent m_onTouchAction;

        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Aie...", this.gameObject);
            m_onTouchAction.Invoke();
        }
    }

}