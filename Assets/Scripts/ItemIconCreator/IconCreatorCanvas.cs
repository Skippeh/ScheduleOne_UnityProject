using UnityEngine;
using UnityEngine.UI;

namespace ItemIconCreator
{
	public class IconCreatorCanvas : MonoBehaviour
	{
		public Text textLabel;

		public GameObject borders;

		public static IconCreatorCanvas instance;

		private void Awake()
		{
		}

		public void SetInfo(int totalItens, int currentItem, string itemName, bool isRecording, KeyCode key)
		{
		}

		public void SetTakingPicture()
		{
		}
	}
}
