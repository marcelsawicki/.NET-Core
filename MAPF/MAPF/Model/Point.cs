﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPF.Model
{
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public Point()
		{

		}

		public Point(int X, int Y)
		{
			this.X = X;
			this.Y = Y;
		}

	}
}