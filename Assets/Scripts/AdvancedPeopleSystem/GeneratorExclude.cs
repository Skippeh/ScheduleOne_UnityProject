using System;
using System.Collections.Generic;

namespace AdvancedPeopleSystem
{
	[Serializable]
	public class GeneratorExclude
	{
		public ExcludeItem ExcludeItem;

		public int targetIndex;

		public List<ExcludeIndexes> exclude;
	}
}
