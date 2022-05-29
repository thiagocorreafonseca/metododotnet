﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.CreateCommand
{
    public class CreateCommentCommand : IRequest<Unit>
    {
        public string Comment { get; set; }
        public int IdUser { get; set; }
        public int IdProject { get; set; }
    }
}
