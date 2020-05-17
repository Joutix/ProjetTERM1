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

    Transform parent;
    public Transform targetTransform;

    Vector3 defaultLocalPosition;
    Vector3 defaultLocalScale;
    Quaternion defaultLocalRotation;
    float animationTime = 1;
    float timeSinceStart;

    void Awake()
    {
        if(instance)
        {
            Debug.LogWarning("Multiples UIManager");
            return;
        }
        instance = this;
        canvas = GetComponent<Canvas>();
        parent = transform.parent;
        defaultLocalPosition = parent.localPosition;
        defaultLocalScale = parent.localScale;
        defaultLocalRotation = parent.localRotation;
    }
    void Update()
    {
        timeSinceStart += Time.deltaTime;
        if (activated) {
            float t = timeSinceStart / animationTime;
            t=t > 1 ? 1 : t;
            parent.position = Vector3.Lerp(parent.position, targetTransform.position, t);
            parent.rotation = Quaternion.Lerp(parent.rotation, targetTransform.rotation, t);
            parent.localScale = Vector3.Lerp(parent.localScale, targetTransform.localScale, t);
        }
        else
        {
            float t = timeSinceStart / animationTime;
            t = t > 1 ? 1 : t;
            parent.localPosition = Vector3.Lerp(parent.localPosition, defaultLocalPosition, t);
            parent.localRotation = Quaternion.Lerp(parent.localRotation, defaultLocalRotation, t);
            parent.localScale = Vector3.Lerp(parent.localScale, defaultLocalScale, t);
        }
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
        activated = true;
        timeSinceStart = 0;
    }
    public void DesactivateUI()
    {
        activated = false;
        timeSinceStart = 0;
    }
}
