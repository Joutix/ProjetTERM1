using UnityEngine;

[CreateAssetMenu(fileName = "Job", menuName = "Job")]
public class Job : ScriptableObject
{
    public Sprite sprite;
    [TextArea(3, 10)]
    public string description;
    public Ressource[] ressources;
}
