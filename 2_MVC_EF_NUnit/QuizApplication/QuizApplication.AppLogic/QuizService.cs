using System;
using System.Collections.Generic;
using System.Linq;
using QuizApplication.AppLogic.Contracts;
using QuizApplication.Domain;

namespace QuizApplication.AppLogic
{
    internal class QuizService : IQuizService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IQuestionRepository _questionRepository;

        public QuizService(ICategoryRepository categoryRepository, IQuestionRepository questionRepository)
        {
            _categoryRepository = categoryRepository;
            _questionRepository = questionRepository;
        }

        public IReadOnlyList<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Question GetQuestionByIdWithAnswersAndExtra(int id)
        {
            Question question = _questionRepository.GetByIdWithAnswers(id);

            if (question.Answers.Where(a => a.IsCorrect == true).Count() == 0)
            {
                question.Answers.Add(new Answer { AnswerText = "None of the answers is correct.", IsCorrect = true });
            } 
            else
            {
                question.Answers.Add(new Answer { AnswerText = "None of the answers is correct.", IsCorrect = false });
            }

            return question;
        }

        public IReadOnlyList<Question> GetQuestionsInCategory(int id)
        {
            return _questionRepository.GetByCategoryId(id);
        }
    }
}
