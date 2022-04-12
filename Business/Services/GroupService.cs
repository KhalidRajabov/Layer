using Business.Interface;
using DataAccess.Repositories;
using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    class GroupService : IGroup 
    {
        public static int Count { get; set; }
        public GroupRepository _groupRepository;
        public GroupService(GroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public Group Create(Group group)
        {
            group.Id = Count;
            _groupRepository.Create(group);
            Count++;
            return group;
        }

        public Group Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Group GetGroup(string name)
        {
            throw new NotImplementedException();
        }

        public Group Update(int id, Group Group)
        {
            throw new NotImplementedException();
        }
    }
}
