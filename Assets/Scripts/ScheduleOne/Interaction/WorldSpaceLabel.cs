using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	public class WorldSpaceLabel
	{
		public string text;

		public Color32 color;

		public Vector3 position;

		public float scale;

		public RectTransform rect;

		public Text textComp;

		public bool active;

		public WorldSpaceLabel(string _text, Vector3 _position)
		{
		}

		public void RefreshDisplay()
		{
		}

		public void Destroy()
		{
		}
	}
}
