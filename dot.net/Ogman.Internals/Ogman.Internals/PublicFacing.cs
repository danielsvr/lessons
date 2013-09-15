using System.Text;

namespace Ogman.Internals
{
    public class PublicFacing : IInternalInterface
    {
        private readonly StringBuilder output;

        public PublicFacing(StringBuilder output)
        {
            this.output = output;
        }

        void IInternalInterface.DoInternalWork()
        {
            output.Append("internal work");
        }

        public void DoWork()
        {
            output.Append("Public work is based on ");
            IInternalInterface internalThis = ((IInternalInterface)this);
            internalThis.DoInternalWork();
            output.Append(".");
        }
    }
}