using UnityEngine;
public class PleaseDieMono : MonoBehaviour
{
    [ContextMenu("Kill Me")]
    public void KillMe()
    {
        this.gameObject.SetActive(false);
    }
    [ContextMenu("Spawn")]
    public void Spawn()
    {
        this.gameObject.SetActive(true);
    }
}
