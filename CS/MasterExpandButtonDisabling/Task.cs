using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterExpandButtonDisabling {
        public class Task {

        public Task(string Name, DateTime start, DateTime finish, bool isComplete, List<string> taskSteps) {
            this.Name = Name;
            StartDate = start;
            FinishDate = finish;
            IsCompleted = isComplete;
            Steps = taskSteps;
        }

        public string Name { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted { get; set; }
        public List<string> Steps { get; set; }
    }
}
