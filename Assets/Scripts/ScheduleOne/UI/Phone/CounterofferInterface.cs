namespace ScheduleOne.UI.Phone
{
	public class CounterofferInterface : global::UnityEngine.MonoBehaviour
	{
		public const int COUNTEROFFER_SUCCESS_XP = 5;

		public const int MinQuantity = 1;

		public int MaxQuantity;

		public const float MinPrice = 1f;

		public const float MaxPrice = 9999f;

		public float IconAlignment;

		public global::UnityEngine.GameObject ProductEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text TitleLabel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.UI.Image ProductIcon;

		public global::UnityEngine.UI.Text ProductLabel;

		public global::UnityEngine.RectTransform ProductLabelRect;

		public global::UnityEngine.UI.InputField PriceInput;

		public global::UnityEngine.UI.Text FairPriceLabel;

		public global::UnityEngine.RectTransform EntryContainer;

		private global::System.Action<global::ScheduleOne.Product.ProductDefinition, int, float> orderConfirmedCallback;

		private global::ScheduleOne.Product.ProductDefinition product;

		private int quantity;

		private float price;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.ProductDefinition, global::UnityEngine.RectTransform> productEntries;

		private bool mouseUp;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.Product.ProductDefinition product, int quantity, float price, global::ScheduleOne.Messaging.MSGConversation _conversation, global::System.Action<global::ScheduleOne.Product.ProductDefinition, int, float> _orderConfirmedCallback)
		{
		}

		private void CreateProductEntry(global::ScheduleOne.Product.ProductDefinition product)
		{
		}

		public void Close()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void Send()
		{
		}

		private void UpdateFairPrice()
		{
		}

		private void SetProduct(global::ScheduleOne.Product.ProductDefinition newProduct)
		{
		}

		private void DisplayProduct(global::ScheduleOne.Product.ProductDefinition tempProduct)
		{
		}

		public void ChangeQuantity(int change)
		{
		}

		private void UpdatePriceQuantityLabel(string productName)
		{
		}

		public void ChangePrice(float change)
		{
		}

		public void PriceSubmitted(string value)
		{
		}

		public void ProductClicked()
		{
		}
	}
}
