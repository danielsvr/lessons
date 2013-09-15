using System.Text;
using NUnit.Framework;

namespace Ogman.Internals.Tests
{
    [TestFixture]
    public class PublicFacingTests
    {
        public class Derived : PublicFacing
        {
            public Derived(StringBuilder output)
                : base(output)
            {
            }

            /*this is not allowed at compile time due non existing virtual method called DoInternalWork*/
            //public override void DoInternalWork()
            //{
            //    
            //}
        }

        [Test]
        public void Test()
        {
            var output = new StringBuilder();
            var inst = new PublicFacing(output);
            inst.DoWork();
            /*this is not allowed at compile time due to low visibility*/
            //inst.DoInternalWork();
            Assert.That(output.ToString(),
                        Is.EqualTo("Public work is based on internal work."));
        }
    }
}