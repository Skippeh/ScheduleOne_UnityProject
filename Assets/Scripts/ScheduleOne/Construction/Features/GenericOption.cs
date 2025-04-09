using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Construction.Features
{
	public class GenericOption : MonoBehaviour
	{
		[Header("Interface settings")]
		public string optionName;

		public Color optionButtonColor;

		public float optionPrice;

		[Header("Events")]
		public UnityEvent onInstalled;

		public UnityEvent onUninstalled;

		public UnityEvent onSetVisible;

		public UnityEvent onSetInvisible;

		public virtual void Install()
		{
		}

		public virtual void Uninstall()
		{
		}

		public virtual void SetVisible()
		{
		}

		public virtual void SetInvisible()
		{
		}
	}
}
