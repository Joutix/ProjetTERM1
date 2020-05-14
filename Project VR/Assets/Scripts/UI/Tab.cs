using UnityEngine;

public abstract class Tab : MonoBehaviour
{
    public abstract void UpdateContent(Piece info);
    public abstract void Activate();
    public abstract void Desactivate();
}
