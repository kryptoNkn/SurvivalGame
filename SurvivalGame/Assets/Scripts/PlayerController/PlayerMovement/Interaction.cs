using TMPro;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public TMP_Text indicator;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.5f))
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
