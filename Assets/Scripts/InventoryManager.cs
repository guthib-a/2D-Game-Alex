using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;
    public int SelectedSlot = 2;
    private Image sr1;
    private Image sr2;
    private Image sr3;
    private Image sr4;
    private Color UnselectedSlotColor = new Color(190, 190, 190);
    private Color SelectedSlotColor = new Color(222, 222, 222);


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr1 = slot1.GetComponent<Image>();
        sr2 = slot2.GetComponent<Image>();
        sr3 = slot3.GetComponent<Image>();
        sr4 = slot4.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        sr1.GetComponent<Image>().color = new Color(Random.Range(0,255f), Random.Range(0,255f), Random.Range(0,255f));

    }
        /*
        sr1.color = new Color(Random.Range(0, 225), Random.Range(0, 225), Random.Range(0, 225));
        //ResetColors();
        if (SelectedSlot == 1)
        {
            sr1.color = SelectedSlotColor;

        }
        if (SelectedSlot == 2)
        {
            sr2.color = SelectedSlotColor;

        }
        if (SelectedSlot == 3)
        {
            sr3.color = SelectedSlotColor;

        }
        if (SelectedSlot == 4)
        {
            sr4.color = SelectedSlotColor;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectedSlot = 1;        }
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
    private void ResetColors()
    {
        sr1.color = UnselectedSlotColor;
        sr2.color = UnselectedSlotColor;
        sr3.color = UnselectedSlotColor;
        sr4.color = UnselectedSlotColor;

    }
        */
}
