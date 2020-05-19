using UnityEngine;

public abstract class Tab : MonoBehaviour
{
    public abstract void UpdateContent(Piece info);
    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }

    public virtual void Desactivate()
    {
        gameObject.SetActive(false);
    }
}
