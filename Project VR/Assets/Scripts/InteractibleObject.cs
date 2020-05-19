using TMPro;
using UnityEngine;

public class InteractibleObject : MonoBehaviour
{
    public Piece piece;
    public TextMeshPro worldTMProName;
    public GameObject traceLineToTextParent;

    bool selected = false;

    private void Start()
    {
        if(worldTMProName!=null) worldTMProName.text = piece.name;
    }

    public void Select()
    {
        UIManager.instance.UpdateContent(piece);
        if(traceLineToTextParent!=null) traceLineToTextParent.SetActive(true);
        selected = true;
    }
    public void UnSelect()
    {
        UIManager.instance.UpdateContent();
        if (traceLineToTextParent != null)  traceLineToTextParent.SetActive(false);
        selected = false;
    }
}
