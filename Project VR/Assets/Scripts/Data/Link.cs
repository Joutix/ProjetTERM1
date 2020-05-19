using UnityEngine;

[CreateAssetMenu(fileName = "Link", menuName = "Ressource/Link")]
public class Link : Ressource
{

    public override void Open()
    {
        Application.OpenURL(path);
    }
}
