using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Projeto 1", "Descricao 1", 1, 1, 10000),
                new Project("Projeto 2", "Descricao 2", 1, 2, 20000),
                new Project("Projeto 3", "Descricao 3", 3, 3, 30000)
            };

            Users = new List<User>
            {
                new User("Usuario 1", "email1@email.com.br", new DateTime(1990, 1, 1)),
                new User("Usuario 2", "email2@email.com.br", new DateTime(1991, 2, 1)),
                new User("Usuario 3", "email3@email.com.br", new DateTime(1992, 3, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".Net"),
                new Skill("C-Sharp"),
                new Skill("Docker"),
                new Skill("Kubernetes")
            }
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
