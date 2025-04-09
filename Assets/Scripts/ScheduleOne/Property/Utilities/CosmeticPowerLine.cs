using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Property.Utilities
{
	public class CosmeticPowerLine : MonoBehaviour
	{
		public Transform startPoint;

		public Transform endPoint;

		public List<Transform> segments;

		public float LengthFactor;

		[Button]
		public void Draw()
		{
		}
	}
}
