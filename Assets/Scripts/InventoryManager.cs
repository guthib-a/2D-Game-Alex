using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public int SelectedSlot = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectedSlot = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SelectedSlot = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SelectedSlot = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SelectedSlot = 4;
        }

    }
}
