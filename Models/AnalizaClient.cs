namespace Proiect_Cicioc_Daniela_Naomi.Models
{
    public class AnalizaClient
    {
        public int ID { get; set; }
        public int AnalizaID { get; set; }
        public Analiza Analize { get; set; }
        public int ClientID { get; set; }
        public Client Clienti { get; set; }
    }
}
