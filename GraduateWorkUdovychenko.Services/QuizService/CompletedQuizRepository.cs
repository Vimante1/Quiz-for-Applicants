﻿using GraduateWorkUdovychenko.Domain.Models.Quiz;
using GraduateWorkUdovychenko.Domain.ViewModels;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateWorkUdovychenko.Services.QuizService
{
    public class CompletedQuizRepository : ICompletedQuizRepository
    {
        private readonly IMongoCollection<CompletedQuizViewModel> _collection;

        public CompletedQuizRepository()
        {
            var client = new MongoClient("mongodb://root:example@132.226.192.36:27017");
            var database = client.GetDatabase("GraduateQuiz");
            _collection = database.GetCollection<CompletedQuizViewModel>("CompletedQuiz");
        }

        public bool Create(CompletedQuizViewModel entity)
        {
            try
            {
                _collection.InsertOneAsync(entity);
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool Delete(CompletedQuizViewModel Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CompletedQuizViewModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}