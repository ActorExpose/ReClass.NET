﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReClassNET
{
	class ViewInfo
	{
		public Graphics Context { get; set; }
		public FontEx Font { get; set; }

		public Memory Memory { get; set; }

		public Rectangle ClientArea { get; set; }
		public List<HotSpot> HotSpots { get; set; }
		public List<Nodes.ClassNode> Classes { get; set; }
		public IntPtr Address { get; set; }
		public int Level { get; set; }
		public bool MultiSelected { get; set; }

		public ViewInfo Clone()
		{
			return new ViewInfo
			{
				Context = Context,
				Font = Font,
				Memory = Memory,
				ClientArea = ClientArea,
				HotSpots = HotSpots,
				Classes = Classes,
				Address = Address,
				Level = Level,
				MultiSelected = MultiSelected
			};
		}
	}
}
