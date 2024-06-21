using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    public TMP_Text indicator;
    public TMP_Text message;
    public GameObject itemInventory;
    public Transform grid;
    
    private void OnMouseOver()
    {
        indicator.enabled = true;
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grid.childCount < 4)
            {
                GameObject clone;
                clone = Instantiate(itemInventory);
                clone.transform.SetParent(grid, false);
                clone.SetActive(true);
                indicator.enabled = false;
                Destroy(gameObject);
            }
            else
            {
                message.enabled = true;
            }
        }
    }

    private void OnMouseExit()
    {
        indicator.enabled = false;
        message.enabled = false;
    }
}