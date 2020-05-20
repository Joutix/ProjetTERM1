using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{

    public Image background;
    public Button button;
    public Tab tab;
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
    public void ActivateTab()
    {
        background.enabled = false;
        button.enabled = false;
        boxcollider.enabled = false;
        tab.Activate();
        UIManager.instance.OnActivateTabButton(this);
        Debug.Log("Activate Tab : " + tab.gameObject.name);
    }
    public void DesactivateTab()
    {
        background.enabled = true;
        button.enabled = true;
        boxcollider.enabled = true;
        tab.Desactivate();
        Debug.Log("Desactivate Tab : " + tab.gameObject.name);
    }
}
