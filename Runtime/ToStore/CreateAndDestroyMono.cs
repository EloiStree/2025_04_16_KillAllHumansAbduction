using UnityEngine;

public class CreateAndDestroyMono : MonoBehaviour
{
    public float m_timeToDie=5;
    public GameObject m_whatToCreate;
    public Transform m_whereToCreate;
    [ContextMenu("Create the prefab")]
    public void CreatePrefab() {
      GameObject gamo =  GameObject.Instantiate(m_whatToCreate);
      gamo.transform.position = m_whereToCreate.transform.position;
      Destroy(gamo, m_timeToDie);
    }
}
