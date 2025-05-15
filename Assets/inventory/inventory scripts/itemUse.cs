using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class itemUse: MonoBehaviour
{
    public Item item;
    public Button RemoveButton;
    public void RemoveItem()
    {
    ItemMgmt.instance.Remove(item);
    Destroy(gameObject);
    }
    public void UseItem()
    {
        Health Playerhp = GameObject.FindWithTag("Player").GetComponent<Health>();
        playerattack playerattack = GameObject.FindWithTag("Player").GetComponent<playerattack>();
        
        switch (item.itemType)
        {


            case Item.ItemType.Potion:
                Debug.Log("Using potion: " + item.itemName);
                Playerhp.Heal(item.Value);
                break;

            case Item.ItemType.hpupgrade:
                Debug.Log("Using health upgrade: " + item.itemName);
                Playerhp.hpupgrade(item.Value);
                break;

            case Item.ItemType.dmgupgrade:
                Debug.Log("Using damage upgrade: " + item.itemName);
                playerattack.dmgupgrade(item.Value);
                break;
        }
        Debug.Log("Using potion: " + item.Value);
        RemoveItem();

    }
}
