using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Impostors
{
	public class ImpostorGenerator : MonoBehaviour
	{
		[Header("References")]
		public Camera ImpostorCamera;

		public Avatar Avatar;

		[Header("Settings")]
		public List<AvatarSettings> GenerationQueue;

		[SerializeField]
		private Texture2D output;
	}
}
