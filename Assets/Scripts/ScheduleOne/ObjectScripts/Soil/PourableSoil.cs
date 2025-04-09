using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerTasks;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts.Soil
{
	public class PourableSoil : Pourable
	{
		public const float TEAR_ANGLE = 10f;

		public const float HIGHLIGHT_CYCLE_TIME = 5f;

		public bool IsOpen;

		public SoilDefinition SoilDefinition;

		[Header("References")]
		public Transform SoilBag;

		public Transform[] Bones;

		public List<Collider> TopColliders;

		public MeshRenderer[] Highlights;

		public Transform TopParent;

		public AudioSourceController SnipSound;

		public SkinnedMeshRenderer TopMesh;

		public UnityEvent onOpened;

		private Vector3 highlightScale;

		private float timeSinceStart;

		public int currentCut { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		private void UpdateHighlights()
		{
		}

		protected override void PourAmount(float amount)
		{
		}

		protected override bool CanPour()
		{
			return false;
		}

		public void Cut()
		{
		}

		private void FinishCut()
		{
		}

		private void LerpCut(int cutIndex)
		{
		}
	}
}
