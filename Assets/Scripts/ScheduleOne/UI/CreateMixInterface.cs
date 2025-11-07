namespace ScheduleOne.UI
{
	public class CreateMixInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.CreateMixInterface>
	{
		public const int BEAN_REQUIREMENT = 5;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::ScheduleOne.UI.ItemSlotUI BeansSlot;

		public global::ScheduleOne.UI.ItemSlotUI ProductSlot;

		public global::ScheduleOne.UI.ItemSlotUI MixerSlot;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlot;

		public global::UnityEngine.UI.Image OutputIcon;

		public global::UnityEngine.UI.Button BeginButton;

		public global::ScheduleOne.Storage.WorldStorageEntity Storage;

		public global::TMPro.TextMeshProUGUI ProductPropertiesLabel;

		public global::TMPro.TextMeshProUGUI OutputPropertiesLabel;

		public global::TMPro.TextMeshProUGUI BeanProblemLabel;

		public global::TMPro.TextMeshProUGUI ProductProblemLabel;

		public global::TMPro.TextMeshProUGUI MixerProblemLabel;

		public global::TMPro.TextMeshProUGUI OutputProblemLabel;

		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.RectTransform UnknownOutputIcon;

		public global::UnityEngine.Events.UnityEvent onOpen;

		public global::UnityEngine.Events.UnityEvent onClose;

		public bool IsOpen { get; private set; }

		private global::ScheduleOne.ItemFramework.ItemSlot beanSlot => null;

		private global::ScheduleOne.ItemFramework.ItemSlot mixerSlot => null;

		private global::ScheduleOne.ItemFramework.ItemSlot outputSlot => null;

		private global::ScheduleOne.ItemFramework.ItemSlot productSlot => null;

		protected override void Awake()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Open()
		{
		}

		private void ContentsChanged()
		{
		}

		private void UpdateCanBegin()
		{
		}

		private void UpdateOutput()
		{
		}

		private void BeginPressed()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> GetOutputProperties(global::ScheduleOne.Product.ProductDefinition product, global::ScheduleOne.Product.PropertyItemDefinition mixer)
		{
			return null;
		}

		private bool IsOutputKnown(out global::ScheduleOne.Product.ProductDefinition knownProduct)
		{
			knownProduct = null;
			return false;
		}

		private string GetPropertyListString(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}

		private string GetPropertyString(global::ScheduleOne.Effects.Effect property)
		{
			return null;
		}

		private bool CanBegin()
		{
			return false;
		}

		public void Close()
		{
		}

		private bool HasProduct()
		{
			return false;
		}

		private bool HasBeans()
		{
			return false;
		}

		private bool HasMixer()
		{
			return false;
		}

		private global::ScheduleOne.Product.ProductDefinition GetProduct()
		{
			return null;
		}

		private global::ScheduleOne.Product.PropertyItemDefinition GetMixer()
		{
			return null;
		}
	}
}
