using TMPro;
using UnityEngine;

public class InteractibleObject : MonoBehaviour
{
    public Piece piece;
    public TextMeshPro worldTMProName;

    private void Start()
    {
        if(worldTMProName!=null) worldTMProName.text = piece.name;
    }
}
