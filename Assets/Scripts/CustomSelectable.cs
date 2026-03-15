public class CustomSelectable : global::UnityEngine.UI.Selectable
{
	public global::UnityEngine.Events.UnityEvent OnSelectionEnter;

	public global::UnityEngine.Events.UnityEvent OnSelectionExit;

	public override void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
	{
	}

	public override void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
	{
	}
}
