using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Addition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Addition" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Addition.svc or Addition.svc.cs at the Solution Explorer and start debugging.
    public class Addition : IAddition
    {

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public MathData[] AddArray(MathData[] md)
        {
            for (int i = 0; i < md.Length; i++)
            {
                md[i].FRsltArg = md[i].FArg1 + md[i].FArg2;
            }
            return md;
        }

    }
}
