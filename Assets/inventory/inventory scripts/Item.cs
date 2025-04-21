using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item :ScriptableObject
{
    public string itemName; 
    public Sprite icon; 
    public int id; 
    public int Value; 
    public ItemType itemType;

    public enum ItemType
    {
        Potion,
        dmgupgrade,
        hpupgrade,
    }

}

    

