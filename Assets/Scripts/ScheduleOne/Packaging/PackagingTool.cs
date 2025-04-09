using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class PackagingTool : MonoBehaviour
	{
		public class PackagingInstance
		{
			public Transform Container;

			public Rigidbody ContainerRb;

			public FunctionalPackaging Packaging;

			public float AnglePosition;

			public void ChangePosition(float angleDelta)
			{
			}
		}

		private const float FinalizeRange_Min = 255f;

		private const float FinalizeRange_Max = 270f;

		[Header("Settings")]
		public float ConveyorSpeed;

		public float ConveyorAcceleration;

		public float BaggieRadius;

		public float JarRadius;

		public float DeployAngle;

		public float ProductInitialForce;

		public float ProductRandomTorque;

		public float KickForce;

		public float DropCooldown;

		[Header("References")]
		public PackagingStation Station;

		public Transform ConveyorModel;

		public Animation DoorAnim;

		public Animation CapAnim;

		public Animation SealAnim;

		public Animation KickAnim;

		public Clickable LeftButton;

		public Clickable RightButton;

		public Clickable DropButton;

		public Transform PackagingContainer;

		public TextMeshPro ProductCountText;

		public Transform HopperDropPoint;

		public Transform BaggieStartPoint;

		public Transform JarStartPoint;

		public Transform ProductContainer;

		public Transform KickOrigin;

		public SphereCollider HopperInputCollider;

		public AudioSourceController KickSound;

		public AudioSourceController MotorSound;

		public AudioSourceController DropSound;

		private FunctionalPackaging PackagingPrefab;

		private int ConcealedPackaging;

		private ProductItemInstance ProductItem;

		private FunctionalProduct ProductPrefab;

		private int ProductInHopper;

		private List<PackagingInstance> PackagingInstances;

		private List<FunctionalProduct> ProductInstances;

		private List<FunctionalPackaging> FinalizedPackaging;

		private float conveyorVelocity;

		private int directionInput;

		private Task task;

		private PackagingInstance finalizeInstance;

		private Coroutine finalizeCoroutine;

		private bool leftDown;

		private bool rightDown;

		private bool dropDown;

		private float timeSinceLastDrop;

		public bool ReceiveInput { get; private set; }

		public void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
		}

		public void Deinitialize()
		{
		}

		private void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
		}

		private void UnloadPackaging()
		{
		}

		private void LoadProduct(ProductItemInstance product, int quantity)
		{
		}

		private void UnloadProduct()
		{
		}

		public void Update()
		{
		}

		private void UpdateInput()
		{
		}

		private void UpdateScreen()
		{
		}

		private void UpdateConveyor()
		{
		}

		private void Rotate(float angle)
		{
		}

		private void CheckDeployPackaging()
		{
		}

		private void CheckFinalize()
		{
		}

		private void Finalize(PackagingInstance instance)
		{
		}

		private void DropProduct()
		{
		}

		private void CheckInsertions()
		{
		}

		private void InsertIntoHopper(FunctionalProduct product)
		{
		}

		private void DeployPackaging()
		{
		}
	}
}
