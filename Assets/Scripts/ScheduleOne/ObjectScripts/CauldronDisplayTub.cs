using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class CauldronDisplayTub : MonoBehaviour
	{
		public enum EContents
		{
			None = 0,
			CocaLeaf = 1
		}

		public Transform CocaLeafContainer;

		public Transform Container_Min;

		public Transform Container_Max;

		public void Configure(EContents contentsType, float fillLevel)
		{
		}
	}
}
