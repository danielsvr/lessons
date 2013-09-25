/*
 * Author: yochanan.miykael
 * Date: 25.09.2013
 *
 */
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CastVsAs
{
	[TestFixture]
	public class ConversionTests
	{
		[Test]
		public void TestCast()
		{
			Foo foo = new Foo{Name = "Foo"};
			Bar bar = (Bar)(foo);
			Assert.That(bar.Name, Is.EqualTo("Bar"));
		}

		[Test]
		public void TestAs()
		{
			Foo foo = new Foo{Name = "Foo"};
			//Bar bar = foo as Bar; //CS0039: Cannot convert type 'CastVsAs.Foo' to 'CastVsAs.Bar' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion
			Bar bar = As<Bar, Foo>(foo); // this is needed to fool the compiler and perform the as operation
			Assert.That(bar, Is.Null);
		}
		
		public TResult As<TResult, T>(T obj) where T : class where TResult:class
		{
			return obj as TResult;
		}
	}
}