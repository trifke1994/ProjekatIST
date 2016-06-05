using System.Runtime.Serialization;

namespace ProjekatIST.Model
{
    [DataContract]
    public class Korisnik
    {
        [DataMember]
        public string KorisnickoIme { get; set; }

        [DataMember]
        public string Lozinka { get; set; }
    }
}