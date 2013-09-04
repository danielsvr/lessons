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
            DoInternalWork();
        }

        public void DoWork()
        {
            output.Append("Public work is based on ");
            DoInternalWork();
            output.Append(".");
        }

        private void DoInternalWork()
        {
            output.Append("internal work");
        }
    }
}