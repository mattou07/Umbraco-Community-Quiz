﻿using Quiz.Site.Enums;
using Quiz.Site.Models;

namespace Quiz.Site.Services;

public interface IQuizResultRepository
{
    IEnumerable<QuizResult> GetAll();

    QuizResult GetById(int id);

    List<QuizResult> GetByIds(int[] ids);

    QuizResult GetByMemberId(int memberId);

    IEnumerable<QuizResult> GetAllByMemberId(int memberId);

    void Create(QuizResult quizResult);

    QuizResult Update(QuizResult quizResult);

    int Delete(int id);

    IEnumerable<PlayerRecord> GetPlayerRecords();
}