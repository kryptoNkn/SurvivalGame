using TMPro;
using UnityEngine;

public enum ItemType
{
    note
}

public class Item : MonoBehaviour
{
    public TMP_Text message;
    public GameObject itemInventory;
    public Transform grid;
    public GameObject note;
    public ItemType itemType;
    public PlayerInteractionUI playerInteractionUI = null;
    
    public void ItemInteraction()
    {
            if (grid.childCount < 4)
            {
                GameObject clone;
                clone = Instantiate(itemInventory);
                clone.transform.SetParent(grid, false);
                clone.SetActive(true);
                Destroy(gameObject);
            }
            else
            {
                message.enabled = true;
            }

            if (itemType == ItemType.note)
            {
                note.SetActive(true);
                playerInteractionUI.InteractionUITrue(); 
            }
    }
}
