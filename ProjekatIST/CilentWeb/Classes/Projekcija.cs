using System;
using System.Runtime.Serialization;

namespace CilentWeb.Model
{
    [DataContract(Namespace = "djukan")]
    public class Projekcija
    {   
        [DataMember]
        public int id_projekcija { get; set; }
        [DataMember]
        public string Naziv { get; set; }
        [DataMember]
        public int Sala { get; set; }
        [DataMember]
        public DateTime Vreme { get; set; }
        [DataMember]
        public int BrojMesta { get; set; }

    }
}
