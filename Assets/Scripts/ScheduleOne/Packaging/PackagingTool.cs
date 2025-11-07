namespace ScheduleOne.Packaging
{
	public class PackagingTool : global::UnityEngine.MonoBehaviour
	{
		public class PackagingInstance
		{
			public global::UnityEngine.Transform Container;

			public global::UnityEngine.Rigidbody ContainerRb;

			public global::ScheduleOne.Packaging.FunctionalPackaging Packaging;

			public float AnglePosition;

			public void ChangePosition(float angleDelta)
			{
			}
		}

		private const float FinalizeRange_Min = 255f;

		private const float FinalizeRange_Max = 270f;

		[global::UnityEngine.Header("Settings")]
		public float ConveyorSpeed;

		public float ConveyorAcceleration;

		public float BaggieRadius;

		public float JarRadius;

		public float DeployAngle;

		public float ProductInitialForce;

		public float ProductRandomTorque;

		public float KickForce;

		public float DropCooldown;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.PackagingStation Station;

		public global::UnityEngine.Transform ConveyorModel;

		public global::UnityEngine.Animation DoorAnim;

		public global::UnityEngine.Animation CapAnim;

		public global::UnityEngine.Animation SealAnim;

		public global::UnityEngine.Animation KickAnim;

		public global::ScheduleOne.PlayerTasks.Clickable LeftButton;

		public global::ScheduleOne.PlayerTasks.Clickable RightButton;

		public global::ScheduleOne.PlayerTasks.Clickable DropButton;

		public global::UnityEngine.Transform PackagingContainer;

		public global::TMPro.TextMeshPro ProductCountText;

		public global::UnityEngine.Transform HopperDropPoint;

		public global::UnityEngine.Transform BaggieStartPoint;

		public global::UnityEngine.Transform JarStartPoint;

		public global::UnityEngine.Transform ProductContainer;

		public global::UnityEngine.Transform KickOrigin;

		public global::UnityEngine.SphereCollider HopperInputCollider;

		public global::ScheduleOne.Audio.AudioSourceController KickSound;

		public global::ScheduleOne.Audio.AudioSourceController MotorSound;

		public global::ScheduleOne.Audio.AudioSourceController DropSound;

		private global::ScheduleOne.Packaging.FunctionalPackaging PackagingPrefab;

		private int ConcealedPackaging;

		private global::ScheduleOne.Product.ProductItemInstance ProductItem;

		private global::ScheduleOne.Product.FunctionalProduct ProductPrefab;

		private int ProductInHopper;

		private global::System.Collections.Generic.List<global::ScheduleOne.Packaging.PackagingTool.PackagingInstance> PackagingInstances;

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.FunctionalProduct> ProductInstances;

		private global::System.Collections.Generic.List<global::ScheduleOne.Packaging.FunctionalPackaging> FinalizedPackaging;

		private float conveyorVelocity;

		private int directionInput;

		private global::ScheduleOne.PlayerTasks.Task task;

		private global::ScheduleOne.Packaging.PackagingTool.PackagingInstance finalizeInstance;

		private global::UnityEngine.Coroutine finalizeCoroutine;

		private bool leftDown;

		private bool rightDown;

		private bool dropDown;

		private float timeSinceLastDrop;

		public bool ReceiveInput { get; private set; }

		public void Initialize(global::ScheduleOne.PlayerTasks.Task _task, global::ScheduleOne.Packaging.FunctionalPackaging packaging, int packagingQuantity, global::ScheduleOne.Product.ProductItemInstance product, int productQuantity)
		{
		}

		public void Deinitialize()
		{
		}

		private void LoadPackaging(global::ScheduleOne.Packaging.FunctionalPackaging prefab, int quantity)
		{
		}

		private void UnloadPackaging()
		{
		}

		private void LoadProduct(global::ScheduleOne.Product.ProductItemInstance product, int quantity)
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

		private void Finalize(global::ScheduleOne.Packaging.PackagingTool.PackagingInstance instance)
		{
		}

		private void DropProduct()
		{
		}

		private void CheckInsertions()
		{
		}

		private void InsertIntoHopper(global::ScheduleOne.Product.FunctionalProduct product)
		{
		}

		private void DeployPackaging()
		{
		}
	}
}
