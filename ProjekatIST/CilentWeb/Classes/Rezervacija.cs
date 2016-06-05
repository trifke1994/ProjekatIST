using System;
using System.Runtime.Serialization;

namespace CilentWeb.Model
{
    [DataContract]
    public class Rezervacija
    {
        [DataMember]
        public int id_rezervacija { get; set; }

        [DataMember]
        public int id_projekcija { get; set; }

        [DataMember]
        public int id_karta { get; set; }

        [DataMember]
        public DateTime datum_kreiranja { get; set; }

        [DataMember]
        public DateTime datum_isteka { get; set; }

        [DataMember]
        public string KorisnickoIme { get; set; }
    }
}