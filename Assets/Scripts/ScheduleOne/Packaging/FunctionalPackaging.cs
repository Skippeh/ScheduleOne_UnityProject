using System;
using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product.Packaging;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class FunctionalPackaging : Draggable
	{
		[Header("Settings")]
		public string SealInstruction;

		public bool AutoEnableSealing;

		public float ProductContactTime;

		public float ProductContactMaxVelocity;

		[Header("References")]
		public PackagingDefinition Definition;

		public Transform AlignmentPoint;

		public Transform[] ProductAlignmentPoints;

		public AudioSourceController SealSound;

		protected List<FunctionalProduct> PackedProducts;

		public Action onFullyPacked;

		public Action onSealed;

		public Action onReachOutput;

		private PackagingStation station;

		private Dictionary<FunctionalProduct, float> productContactTime;

		private SmoothedVelocityCalculator VelocityCalculator;

		public bool IsSealed { get; protected set; }

		public bool IsFull { get; protected set; }

		public bool ReachedOutput { get; protected set; }

		public virtual void Initialize(PackagingStation _station, Transform alignment, bool align = true)
		{
		}

		public void AlignTo(Transform alignment)
		{
		}

		public virtual void Destroy()
		{
		}

		protected override void FixedUpdate()
		{
		}

		protected virtual void PackProduct(FunctionalProduct product)
		{
		}

		protected virtual void FullyPacked()
		{
		}

		protected virtual void OnTriggerStay(Collider other)
		{
		}

		protected virtual void EnableSealing()
		{
		}

		public virtual void Seal()
		{
		}
	}
}
