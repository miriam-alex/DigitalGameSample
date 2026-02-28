using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GridInventory playerInventory; // Assign in Inspector or via script
    public Image[] slotImages; // Assign in Inspector (drag each Slot's Image here)
    public GameObject playerObject; // Assign in Inspector or via script

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (slotImages == null) return;
        // If playerObject is assigned, show all carried objects
        if (playerObject != null)
        {
            var controller = playerObject.GetComponent<playerController>();
            if (controller != null)
            {
                // Gather all carried objects
                var carriedObjects = new System.Collections.Generic.List<GameObject>();
                if (controller.isCarryingObject && controller.objectToGrab != null)
                    carriedObjects.Add(controller.objectToGrab);
                if (controller.listobjectsToGrab != null && controller.listobjectsToGrab.Count > 0)
                    carriedObjects.AddRange(controller.listobjectsToGrab);

                // Populate UI slots with carried items
                for (int i = 0; i < slotImages.Length; i++)
                {
                    if (i < carriedObjects.Count)
                    {
                        InventoryItem item = carriedObjects[i].GetComponent<InventoryItem>();
                        if (item != null && item.icon != null)
                            slotImages[i].sprite = item.icon;
                        else
                            slotImages[i].sprite = null;
                    }
                    else
                    {
                        slotImages[i].sprite = null; // Or set to default empty sprite
                    }
                }
                return;
            }
        }
        // If no player or no carried objects, clear all slots
        for (int i = 0; i < slotImages.Length; i++)
        {
            slotImages[i].sprite = null;
        }
    }
}
