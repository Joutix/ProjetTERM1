using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JobUI : MonoBehaviour
{
    public TextMeshProUGUI tmProName;
    public TextMeshProUGUI tmProDescriptionUI;
    public Image image;

    public void UpdateContent(Job job)
    {
        tmProName.text=job.name;
        tmProDescriptionUI.text=job.description;
        image.sprite=job.sprite;
    }
}
