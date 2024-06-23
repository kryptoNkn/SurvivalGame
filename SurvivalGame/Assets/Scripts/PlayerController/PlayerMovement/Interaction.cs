using TMPro;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public TMP_Text indicator;
    private Gun gunScript;
    public GameObject gun1;
    public GameObject gun2;

    private void Start()
    {
        gunScript = FindObjectOfType<Gun>();
        gunScript.enabled = false;
    }

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
            
            else if (hit.collider.tag == "Gun")
            {
                indicator.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    gun1.SetActive(false);
                    gun2.SetActive(true);
                    gunScript.enabled = true; 
                    
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
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && gun2.activeSelf)
        {
            gun2.SetActive(false);
            gunScript.enabled = false; 
        }
    }
}
