﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Piranha.Rest.DataContracts
{
	[DataContract()]
	public class Region {
		[DataMember()]
		public string Name { get ; set ; }
		[DataMember()]
		public string Body { get ; set ; }
	}
}
