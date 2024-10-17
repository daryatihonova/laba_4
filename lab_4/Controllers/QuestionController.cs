using lab_4.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab_4.Controllers
{
    [Route("question")]
    public class QuestionController : Controller
    {
        private SurveyDataContext db = new SurveyDataContext();

        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Questions = db.Questions.ToList();
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(IFormCollection iformCollection)
        {
            int score = 0;
            string[] questionIds = iformCollection["questionId"];
            foreach (var questionId in questionIds)
            {
                int answerIdCorrect = db.Questions.Find(int.Parse(questionId))
                    .Answers.Where(a => a.Correct == true).FirstOrDefault().Id;
                if (answerIdCorrect == int.Parse(iformCollection["question_"
                    + questionId]))
                {
                    score++;
                }
            }
            ViewBag.score = score;
            return View("Result");
        }

    }
}
