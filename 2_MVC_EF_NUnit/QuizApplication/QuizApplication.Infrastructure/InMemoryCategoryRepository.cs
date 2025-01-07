﻿using QuizApplication.AppLogic.Contracts;
using QuizApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication.Infrastructure
{
    internal class InMemoryCategoryRepository : ICategoryRepository
    {
        /* This is an in-memory repository, you do NOT need EF for this. */
        private readonly List<Category> _categories;

        public InMemoryCategoryRepository()
        {
            _categories = new List<Category> {
            new Category
            {
                Id = 1,
                Name = "Biology"
            },
            new Category
            {
                Id = 2,
                Name = "Arts and Culture"
            },
            new Category
            {
                Id = 3,
                Name = "Astronomy"
            },
             new Category
            {
                Id = 4,
                Name = "Geography"
            }
         };
        }

        public IReadOnlyList<Category> GetAll()
        {
            return _categories;
        }

        public Category? GetById(int id)
        {
            return _categories[id];
        }
    }
}
