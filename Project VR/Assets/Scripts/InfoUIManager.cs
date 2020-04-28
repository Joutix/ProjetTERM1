using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoUIManager : MonoBehaviour
{
    public static InfoUIManager instance;

    public TextMeshProUGUI tmProName;
    public Image image;
    public TextMeshProUGUI tmProDescription;

    void Awake()
    {
        if(instance)
        {
            Debug.LogWarning("Multiples InfoUIManager");
            return;
        }
        instance = this;
    }

    public void UpdateInfoUI(Info info=null)
    {
        if (info == null)
        {
            tmProName.text = "Name";
            image.sprite = null;
            tmProDescription.text = "Empty Description";
        }
        else
        {
            tmProName.text = info.name;
            image.sprite = info.image;
            tmProDescription.text = info.description;
        }
    }
}
