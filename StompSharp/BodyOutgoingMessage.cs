using System.Collections.Generic;
using System.Linq;

namespace Stomp2
{
    internal class BodyOutgoingMessage : IOutgoingMessage
    {
        private readonly byte[] _body;

        public byte[] Body
        {
            get { return _body; }
        }

        public IEnumerable<IHeader> Headers
        {
            get
            {
                yield return new Header("content-type", "application/octet-stream; charset=ASCII");
                //return Enumerable.Empty<IHeader>(); 
                
            }
        }

        public BodyOutgoingMessage(byte[] body)
        {
            _body = body;
        }
    }
}