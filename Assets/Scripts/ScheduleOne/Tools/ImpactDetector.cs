using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	public class ImpactDetector : MonoBehaviour
	{
		public bool DestroyScriptOnImpact;

		public UnityEvent onImpact;

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
