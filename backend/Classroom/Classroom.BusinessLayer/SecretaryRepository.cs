﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classroom.BusinessLayer.Interfaces;
using Classroom.DataLayer;
using Classroom.Entities;
using Classroom.Entities.Models;

namespace Classroom.BusinessLayer
{
    public class SecretaryRepository : Repository<Secretary>, ISecretaryRepository
    {
        public SecretaryRepository(ClassroomContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
