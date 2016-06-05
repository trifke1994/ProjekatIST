using System.Runtime.Serialization;

namespace ProjekatIST.Model
{
    [DataContract]
    public class Karta
    {
        [DataMember]
        public int id_karta { get; set; }

        [DataMember]
        public double Cena { get; set; }

        [DataMember]
        public int id_projekcija { get; set; }
    }
}