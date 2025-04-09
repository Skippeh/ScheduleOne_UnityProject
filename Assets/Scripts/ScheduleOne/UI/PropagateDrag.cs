using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	[RequireComponent(typeof(EventTrigger))]
	public class PropagateDrag : MonoBehaviour
	{
		public ScrollRect ScrollView;

		private void Start()
		{
		}
	}
}
