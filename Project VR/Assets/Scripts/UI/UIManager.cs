using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TabButton current;

    public TabButton[] tabButtons;
    public Tab[] tabs;


    void Awake()
    {
        if(instance)
        {
            Debug.LogWarning("Multiples UIManager");
            return;
        }
        instance = this;
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
}
