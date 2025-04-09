using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "Avatar Layer", menuName = "ScriptableObjects/Avatar Layer", order = 1)]
	public class AvatarLayer : ScriptableObject
	{
		public string Name;

		public string AssetPath;

		public Texture2D Texture;

		public Texture2D Normal;

		public Texture2D Normal_DefaultFormat;

		public int Order;

		public Material CombinedMaterial;
	}
}
