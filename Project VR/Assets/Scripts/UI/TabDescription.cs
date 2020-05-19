using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TabDescription : Tab
{
    public TextMeshProUGUI tmProObjName;
    public Image image;
    public TextMeshProUGUI tmProDescription;


    public override void UpdateContent(Piece piece)
    {
        if (piece == null)
        {
            tmProObjName.text = "Name";
            image.sprite = null;
            tmProDescription.text = "Description";
        }
        else
        {
            tmProObjName.text = piece.name;
            image.sprite = piece.sprite;
            tmProDescription.text = piece.description;
        }
    }
}
