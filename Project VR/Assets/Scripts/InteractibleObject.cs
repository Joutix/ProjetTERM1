using TMPro;
using UnityEngine;

public class InteractibleObject : MonoBehaviour
{
    public Info info;
    public TextMeshPro worldTMProName;
    public GameObject traceLineToTextParent;
    bool selected = false;
    private void Start()
    {
        if(worldTMProName!=null) worldTMProName.text = info.name;
    }
    public void Select()
    {
        InfoUIManager.instance.UpdateInfoUI(info);
        if(traceLineToTextParent!=null) traceLineToTextParent.SetActive(true);
        selected = true;
    }
    public void UnSelect()
    {
        InfoUIManager.instance.UpdateInfoUI();
        if (traceLineToTextParent != null)  traceLineToTextParent.SetActive(false);
        selected = false;
    }
}
