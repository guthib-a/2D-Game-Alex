using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Image image;
  [HideInInspector] public Transform ParentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin");
        ParentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end");
        transform.SetParent(ParentAfterDrag);
        image.raycastTarget = true; 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created

}
