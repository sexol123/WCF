using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.ServiceModel;

namespace WcfExamService
{
    [DataContract]
    [Table(Name = "Table")]
    public class Gamer
    {
        [DataMember]
        [Column(IsDbGenerated = true,IsPrimaryKey = true,Name = "Id")]
        public int GamerId { get; set; } = 88;
        [DataMember]
        [Column]
        public  string NickName { get;  set; }
        [DataMember]
        [Column]
        public string Login { get; set; }
        [Column]
        [DataMember]
        public string Passwd { get; set; }

        public override string ToString()
        {
            return " ["+this.GamerId +"] "+ this.NickName;
        }
    }
}