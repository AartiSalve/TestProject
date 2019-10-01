//using Newtonsoft.Json;
//using ProtoBuf;
//using System;
//using System.Xml.Serialization;

//namespace ProjectSamples
//{
//    [Serializable]
//    [ProtoContract]
//    public class ResultMessage
//    {
//        [ProtoMember(1)]
//        public RequestContext RequestContext
//        {
//            get;
//            set;
//        }
//    }

//    [Serializable]
//    [ProtoContract]
//    public class Result<T> : ResultMessage
//    {
//        [ProtoMember(2)]
//        public T Data
//        {
//            get;
//            set;
//        }

//        [ProtoMember(3)]
//        public int ResultCode
//        {
//            get;
//            set;
//        }

//        [ProtoIgnore]
//        [JsonIgnore]
//        [XmlIgnore]
//        public bool IsSuccess
//        {
//            get
//            {
//                return ResultCode == (int)CoreCodes.NoError;
//            }
//        }
//    }
//}
