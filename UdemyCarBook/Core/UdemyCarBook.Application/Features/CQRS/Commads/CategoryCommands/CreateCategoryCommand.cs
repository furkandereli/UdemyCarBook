﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commads.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string Name { get; set; }
    }
}
