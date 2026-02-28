using UnityEngine;

public class GridInventory : MonoBehaviour
{
    public int gridWidth = 5;
    public int gridHeight = 4;
    public InventoryItem[,] items;

    private void Awake()
    {
        items = new InventoryItem[gridWidth, gridHeight];
    }

    // Adds an item to the grid at the specified position if space is available
    public bool AddItem(InventoryItem item, int x, int y)
    {
        if (CanPlaceItem(item, x, y))
        {
            for (int i = 0; i < item.width; i++)
            {
                for (int j = 0; j < item.height; j++)
                {
                    items[x + i, y + j] = item;
                }
            }
            return true;
        }
        return false;
    }

    // Removes an item from the grid
    public void RemoveItem(int x, int y)
    {
        InventoryItem item = items[x, y];
        if (item == null) return;
        for (int i = 0; i < item.width; i++)
        {
            for (int j = 0; j < item.height; j++)
            {
                if (x + i < gridWidth && y + j < gridHeight && items[x + i, y + j] == item)
                    items[x + i, y + j] = null;
            }
        }
    }

    // Checks if an item can be placed at the specified position
    public bool CanPlaceItem(InventoryItem item, int x, int y)
    {
        if (x + item.width > gridWidth || y + item.height > gridHeight)
            return false;
        for (int i = 0; i < item.width; i++)
        {
            for (int j = 0; j < item.height; j++)
            {
                if (items[x + i, y + j] != null)
                    return false;
            }
        }
        return true;
    }

    // Moves an item from one position to another
    public bool MoveItem(int fromX, int fromY, int toX, int toY)
    {
        InventoryItem item = items[fromX, fromY];
        if (item == null) return false;
        RemoveItem(fromX, fromY);
        if (AddItem(item, toX, toY))
            return true;
        // If move failed, put it back
        AddItem(item, fromX, fromY);
        return false;
    }
}
