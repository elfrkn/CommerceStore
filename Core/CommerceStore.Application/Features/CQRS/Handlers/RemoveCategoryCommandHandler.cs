﻿using CommerceStore.Application.Features.CQRS.Commands;
using CommerceStore.Application.Interfaces;
using CommerceStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommerceStore.Application.Features.CQRS.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public RemoveCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCategoryCommand comman)
        {
            await _repository.DeleteAsync(comman.Id);
        }
    }
}