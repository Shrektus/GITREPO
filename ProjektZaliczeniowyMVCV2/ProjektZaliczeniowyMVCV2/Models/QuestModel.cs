using System.ComponentModel;

namespace ProjektZaliczeniowyMVCV2.Models
{
    public class QuestModel
    {
        public int Id { get; set; }
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Opis")]
        public string Description { get; set; }
        [DisplayName("Nagroda")]
        public string Reward { get; set; }
        [DisplayName("Data utworzenia")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Data wygaśnięcia")]
        public DateTime ExpirationDate { get; set; }
        [DisplayName("Aktywne")]
        public bool Active { get; set; }
        public QuestModel()
        {
            CreationDate = DateTime.Now;
            Active = true;
            ExpirationDate = DateTime.Now.AddDays(30);
        }

    }
}
