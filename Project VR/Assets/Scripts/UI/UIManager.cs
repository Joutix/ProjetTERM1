using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TabButton current;

    public TabButton[] tabButtons;
    public Tab[] tabs;

    [HideInInspector]
    bool activated;

    Canvas canvas;

    void Awake()
    {
        if(instance)
        {
            Debug.LogWarning("Multiples InfoUIManager");
            return;
        }
        instance = this;
        canvas = GetComponent<Canvas>();
    }

    public void UpdateContent(Piece piece=null)
    {
        foreach(Tab t in tabs)
        {
            t.UpdateContent(piece);
        }        
    }

    public void OnActivateTabButton(TabButton newTabButton)
    {
        current.DesactivateTab();
        current = newTabButton;
    }
    public bool IsActivated()
    {
        return activated;
    }

    public void ActivateUI()
    {
        canvas.enabled=true;
        activated = true;
    }
    public void DesactivateUI()
    {
        activated = false;
        canvas.enabled=false;
    }
}
