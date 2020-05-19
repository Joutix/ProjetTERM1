using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RessourceUI : MonoBehaviour
{
    public TextMeshProUGUI tmProName;
    public Image image;
    [HideInInspector]
    public Ressource ressource;
    public void UpdateContent(Ressource ressource)
    {
        tmProName.text=ressource.name;
        image.sprite= ressource.icon;
        this.ressource = ressource;
    }
    public void OpenRessource()
    {
        if (ressource != null) ressource.Open();
    }
}
