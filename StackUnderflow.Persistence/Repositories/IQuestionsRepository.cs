﻿#region

using StackUnderflow.Model.Entities;
using StackUnderflow.Model.Entities.DB;

#endregion

namespace StackUnderflow.Persistence.Repositories
{
    public interface IQuestionsRepository : IRepository<Question>
    {
        Question[] GetNewestQuestions(int numberOfQuestions);
    }
}