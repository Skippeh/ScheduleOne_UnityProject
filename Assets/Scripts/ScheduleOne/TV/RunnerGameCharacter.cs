using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.TV
{
	public class RunnerGameCharacter : MonoBehaviour
	{
		public RunnerGame Game;

		public UnityEvent onHit;

		public void OnTriggerEnter(Collider other)
		{
		}
	}
}
