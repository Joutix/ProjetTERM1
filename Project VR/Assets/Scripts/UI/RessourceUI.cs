using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RessourceUI : MonoBehaviour
{
    public TextMeshProUGUI tmProName;
    public Image image;
    [HideInInspector]
    public Ressource ressource;
    BoxCollider boxcollider;
    RectTransform rectTransform;
    private void Awake()
    {
        boxcollider = GetComponent<BoxCollider>();
        rectTransform = (RectTransform)transform;
    }
    private void Update()
    {
        boxcollider.size = new Vector3(rectTransform.rect.width, rectTransform.rect.height, 20f);
    }

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
