using UnityEngine;

public abstract class Ressource : ScriptableObject
{
    public string path;
    public Sprite icon;

    public abstract void Open();
}
