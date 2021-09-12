using UnityEngine;

using UnityEngine.EventSystems;

 
//Muslimah 439
public class TapArea : MonoBehaviour, IPointerDownHandler

{

    public void OnPointerDown (PointerEventData eventData)

    {

        GameManager.Instance.CollectByTap (eventData.position, transform);

    }

}