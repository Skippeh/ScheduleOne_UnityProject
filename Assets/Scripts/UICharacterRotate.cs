using UnityEngine;
using UnityEngine.EventSystems;

public class UICharacterRotate : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public UIControllerDEMO uIController;

	public float mouseRotateCharacterPower;

	private bool toogle;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}
}
