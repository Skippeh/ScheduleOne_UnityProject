using System;
using System.Collections.Generic;

namespace UnityEngine.PostProcessing
{
	public sealed class MaterialFactory : IDisposable
	{
		private Dictionary<string, Material> m_Materials;

		public Material Get(string shaderName)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
