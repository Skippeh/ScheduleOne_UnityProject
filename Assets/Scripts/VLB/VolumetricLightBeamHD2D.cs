namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.SelectionBase]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class VolumetricLightBeamHD2D : global::VLB.VolumetricLightBeamHD
	{
		[global::UnityEngine.SerializeField]
		private int m_SortingLayerID;

		[global::UnityEngine.SerializeField]
		private int m_SortingOrder;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override global::VLB.Dimensions GetDimensions()
		{
			return default(global::VLB.Dimensions);
		}

		public override bool DoesSupportSorting2D()
		{
			return false;
		}

		public override int GetSortingLayerID()
		{
			return 0;
		}

		public override int GetSortingOrder()
		{
			return 0;
		}
	}
}
