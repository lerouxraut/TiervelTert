using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public abstract class ModelBase
    {
        Guid pocoId = Guid.NewGuid();

        public Guid PocoId { get { return pocoId; } }

        public virtual void SetDbId(object id)
        {//Each POCO should override this method for specific implementation.
            throw new NotImplementedException("This method is not implemented by Poco.");
        }

        public override string ToString()
        {
            return PocoId + Environment.NewLine + base.ToString();
        }
    }
}
