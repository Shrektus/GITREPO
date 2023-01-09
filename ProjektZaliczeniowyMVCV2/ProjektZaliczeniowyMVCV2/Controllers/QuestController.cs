using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjektZaliczeniowyMVCV2.Logic;
using ProjektZaliczeniowyMVCV2.Models;

namespace ProjektZaliczeniowyMVCV2.Controllers
{
    public class QuestController : Controller
    {
        QuestManager questManager = new QuestManager(); 
        
        public IActionResult Index()
        {
            var list = questManager.GetAllQuests();
            return View(list);
        }
        public IActionResult GetActive()
        {
            var list = questManager.GetActiveQuests();
            return View(list);
        }

        [HttpGet]
       public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(QuestModel questModel)
        {
            questManager.AddQuest(questModel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var quest = questManager.GetQuest(id);
            return View(quest);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            questManager.RemoveQuest(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var quest = questManager.GetQuest(id);
            return View(quest);
        }
        [HttpPost]
        public IActionResult Edit(QuestModel quest)
        {
            questManager.UpdateQuest(quest);
            return RedirectToAction("Index");
        }

    }
}
