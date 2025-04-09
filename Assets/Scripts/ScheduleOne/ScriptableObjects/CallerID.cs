using System;
using UnityEngine;

namespace ScheduleOne.ScriptableObjects
{
	[Serializable]
	[CreateAssetMenu(fileName = "CallerID", menuName = "ScriptableObjects/CallerID", order = 1)]
	public class CallerID : ScriptableObject
	{
		public string Name;

		public Sprite ProfilePicture;
	}
}
