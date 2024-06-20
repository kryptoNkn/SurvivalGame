using UnityEngine;

public class Inventory : MonoBehaviour
{
  public GameObject inventory;
  public bool flag = false;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Tab))
    {
      flag = !flag;
      inventory.SetActive(flag);
    }
  }
}
