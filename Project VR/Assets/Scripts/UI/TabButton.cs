using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{

    public Image background;
    public Button button;
    public Tab tab;
    
    public void ActivateTab()
    {
        background.enabled = false;
        button.enabled = false;
        tab.Activate();
        UIManager.instance.OnActivateTabButton(this);
        Debug.Log("Activate Tab : " + tab.gameObject.name);
    }
    public void DesactivateTab()
    {
        background.enabled = true;
        button.enabled = true;
        tab.Desactivate();
        Debug.Log("Desactivate Tab : " + tab.gameObject.name);
    }
}
