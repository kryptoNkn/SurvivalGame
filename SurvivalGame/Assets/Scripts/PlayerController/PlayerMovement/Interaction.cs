using TMPro;
using UnityEditor;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public TMP_Text indicator;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.collider.tag == "Item")
            {
                indicator.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<Item>().ItemInteraction();
                }
            }
            else
            {
                indicator.enabled = false;
            }
        }
        else
        {
            indicator.enabled = false;
        }
    }
}
