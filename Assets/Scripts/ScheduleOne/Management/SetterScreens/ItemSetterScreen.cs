using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets.Options;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Management.SetterScreens
{
	public class ItemSetterScreen : Singleton<ItemSetterScreen>
	{
		private class Pair
		{
			public string prefabID;

			public RectTransform entry;
		}

		[Header("Prefabs")]
		public GameObject ListEntryPrefab;

		[Header("References")]
		public RectTransform EntryContainer;

		public TextMeshProUGUI TitleLabel;

		private RectTransform allEntry;

		private RectTransform noneEntry;

		private List<Pair> pairs;

		public ItemList Option { get; private set; }

		public bool IsOpen => false;

		protected override void Awake()
		{
		}

		public virtual void Open(ItemList option)
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public virtual void Close()
		{
		}

		private RectTransform CreateEntry(Sprite icon, string label, Action onClick, string prefabID = "", bool createPair = false)
		{
			return null;
		}

		private void AllClicked()
		{
		}

		private void NoneClicked()
		{
		}

		private void EntryClicked(string prefabID)
		{
		}

		private void RefreshTicks()
		{
		}

		private void SetEntryTicked(RectTransform entry, bool ticked)
		{
		}

		private void CreateEntries()
		{
		}

		private void DestroyEntries()
		{
		}
	}
}
