﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Addition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAddition" in both code and config file together.
    [ServiceContract]
    public interface IAddition
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string GetDataUsingDataContract1(string composite);

        // TODO: Add your service operations here
        [OperationContract]
        List<MathData> AddUD(ref List<MathData> md);

        [OperationContract]
        MathData[] AddArray(MathData[] md);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value + value + value; }
        }
    }

    [DataContract]
    public class MathData
    {
        [DataMember]
        public Int32 FArg1 { get ; set;  }
        [DataMember]
        public Int32 FArg2 { get; set; }
        [DataMember]
        public Int32 FRsltArg { get; set; }

        [DataMember]
        public string StrArg1 { get; set; }
        [DataMember]
        public string StrArg2 { get; set; }
        [DataMember]
        public string StrConcatRslt { get; set; }
    }
}
