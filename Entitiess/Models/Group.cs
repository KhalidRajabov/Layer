using Entitiess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Models
{
    public class Group:IEntity
    {
     
        public string Name { get; set; }
        public int MaxSize { get; set; }
        public int Id { get ; set ; }
    }
}
