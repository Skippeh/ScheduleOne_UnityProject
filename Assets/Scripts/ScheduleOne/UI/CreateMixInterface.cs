using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;
using ScheduleOne.Storage;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		public const int BEAN_REQUIREMENT = 5;

		[Header("References")]
		public Canvas Canvas;

		public ItemSlotUI BeansSlot;

		public ItemSlotUI ProductSlot;

		public ItemSlotUI MixerSlot;

		public ItemSlotUI OutputSlot;

		public Image OutputIcon;

		public Button BeginButton;

		public WorldStorageEntity Storage;

		public TextMeshProUGUI ProductPropertiesLabel;

		public TextMeshProUGUI OutputPropertiesLabel;

		public TextMeshProUGUI BeanProblemLabel;

		public TextMeshProUGUI ProductProblemLabel;

		public TextMeshProUGUI MixerProblemLabel;

		public TextMeshProUGUI OutputProblemLabel;

		public Transform CameraPosition;

		public RectTransform UnknownOutputIcon;

		public UnityEvent onOpen;

		public UnityEvent onClose;

		public bool IsOpen { get; private set; }

		private ItemSlot beanSlot => null;

		private ItemSlot mixerSlot => null;

		private ItemSlot outputSlot => null;

		private ItemSlot productSlot => null;

		protected override void Awake()
		{
		}

		private void Exit(ExitAction action)
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

		private List<ScheduleOne.Properties.Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			return null;
		}

		private bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			knownProduct = null;
			return false;
		}

		private string GetPropertyListString(List<ScheduleOne.Properties.Property> properties)
		{
			return null;
		}

		private string GetPropertyString(ScheduleOne.Properties.Property property)
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

		private ProductDefinition GetProduct()
		{
			return null;
		}

		private PropertyItemDefinition GetMixer()
		{
			return null;
		}
	}
}
