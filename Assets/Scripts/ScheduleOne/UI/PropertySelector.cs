using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class PropertySelector : MonoBehaviour
	{
		public delegate void PropertySelected(ScheduleOne.Property.Property p);

		[Header("References")]
		[SerializeField]
		protected GameObject container;

		[SerializeField]
		protected RectTransform buttonContainer;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		private PropertySelected pCallback;

		public bool isOpen => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void Exit(ExitAction exit)
		{
		}

		public void OpenSelector(PropertySelected p)
		{
		}

		private void PropertyAcquired(ScheduleOne.Property.Property p)
		{
		}

		private void SelectProperty(ScheduleOne.Property.Property p)
		{
		}

		private void Close(bool reenableShit)
		{
		}
	}
}
