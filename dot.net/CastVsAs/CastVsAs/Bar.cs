/*
 * Author: yochanan.miykael
 * Date: 25.09.2013
 *
 */
using System;

namespace CastVsAs
{
	public class Bar : Stuff
	{
		public string Name { get; set; }
		
		public static explicit operator Bar(Foo foo)
		{
			return new Bar() { Name = "Bar" };
		}
	}
}
