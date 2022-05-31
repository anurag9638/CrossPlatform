using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    [SerializeField] private Item item;
    [SerializeField] private Button pickupButton;
    private void Update()
    {
      
    }
    public void CheckCollect(RaycastHit hit, KeyCode keyCode)
    {
      
        {
            bool wasPickedUp = Inventory.Instance.AddItem(item);

            if (wasPickedUp)
            {
                Destroy(hit.transform.gameObject);
            }
        }
            
        
    }
}
