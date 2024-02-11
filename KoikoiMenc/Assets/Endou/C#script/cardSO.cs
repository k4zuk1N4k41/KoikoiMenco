using UnityEngine;

[CreateAssetMenu]
public class cardSO : ScriptableObject
{
    new public string name = "New Card";
    public Sprite icon = null;
    public void Equipment()
    {
        Debug.Log(name);
    }
}