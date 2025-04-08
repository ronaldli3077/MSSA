using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Enumdemo
{
    enum Status
    {
        NotStarted=1,
        OnHold,
        InProgress,
        Completed,
        Dismissed
    }
    internal class ToDo
    {
        public int TaskId {  get; set; }
        public string ?Description {  get; set; }
        public float EstimatedHours {  get; set; }
        public Status TaskStatus { get; set; }

    }
}
