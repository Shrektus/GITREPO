using ProjektZaliczeniowyMVCV2.Models;
namespace ProjektZaliczeniowyMVCV2.Logic
{

    public class QuestManager
    {
        public QuestManager AddQuest(QuestModel questModel)
        {
            using (var context = new QuestContext())
            {
                try
                {
                    context.Quests.Add(questModel);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    questModel.Id = 0;
                    context.Quests.Add(questModel);
                    context.SaveChanges();
                }
            }
            return this;
        }

        public QuestManager RemoveQuest(int id)
        {
            
            using(var context = new QuestContext())
            {
                QuestModel questModelToDelete;
                questModelToDelete = context.Quests.Single(x=>  x.Id== id);
                context.Quests.Remove(questModelToDelete);
                context.SaveChanges();
            }
            return this;
        }

        public QuestManager UpdateQuest(QuestModel questModel)
        {
            using (var context = new QuestContext())
            {
                context.Quests.Update(questModel);
                context.SaveChanges();
            }
                return this;
        }

        public QuestModel GetQuest(int id)
        {
            using (var context = new QuestContext())
            {
                var quest = context.Quests.Single(x => x.Id == id);
                return quest;
            }
        }

        public List<QuestModel> GetAllQuests()
        {
            using (var context = new QuestContext())
            {
                var quest = context.Quests.ToList();
                return quest;
            }
        }
        public List<QuestModel> GetActiveQuests()
        {
            using (var context = new QuestContext())
            {
                var quest = context.Quests.Where(x => x.Active == true).ToList();
                return quest;
            }
        }
    }
}
