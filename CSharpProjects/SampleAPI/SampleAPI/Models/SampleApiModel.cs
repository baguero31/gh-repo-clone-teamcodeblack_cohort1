using System;
using System.Runtime.Serialization;

namespace SampleAPI.Models
{

    [DataContract]
    public class SampleApiModel
    {
        [DataMember(Name = "tableID", EmitDefaultValue = false)]
        public int TableID { get; set; }

        [DataMember(Name = "getTableDate", EmitDefaultValue = false)]
        public string GetTableDate { get; set; }
        
        [DataMember(Name = "getTableColumn1", EmitDefaultValue = false)]
        public string GetTableColumn1 { get; set; }

        [DataMember(Name = "getTableColumn2", EmitDefaultValue = false)]
        public string GetTableColumn2 { get; set; }

        [DataMember(Name = "getTableBoolean", EmitDefaultValue = false)]
        public bool IsGetTableColumnBoolean { get; set; }
    }
}
