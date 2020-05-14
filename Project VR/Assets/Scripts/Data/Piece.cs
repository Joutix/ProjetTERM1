using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Piece", menuName = "Piece")]
public class Piece : ScriptableObject
{
    //name is the name of the ScriptableObject

    public Sprite sprite;
    [TextArea(3, 10)]
    public string description;
    public Job[] jobs;
    public string[] sub_parts;
}
