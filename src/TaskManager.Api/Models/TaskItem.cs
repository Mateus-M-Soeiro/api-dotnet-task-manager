using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Api.Models;

namespace TaskManager.Api.DTOs
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public EnumStatus Status { get; set; }

        public Guid UserId { get; set; }
    }
}