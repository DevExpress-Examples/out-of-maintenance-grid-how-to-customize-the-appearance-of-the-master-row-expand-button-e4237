using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public static ObservableCollection<Task> GetList {
            get {
                ObservableCollection<Task> tasks = new ObservableCollection<Task>();
                tasks.Add(new Task("Task1", new DateTime(2012, 9, 3), DateTime.Now, true, new List<string>() { }));
                tasks.Add(new Task("Task2", DateTime.Now, new DateTime(2012, 9, 7), false, new List<string>() { "Step1", "Step2", "Step3", "Step4" }));
                tasks.Add(new Task("Task3", new DateTime(2012, 8, 12), DateTime.Now, true, new List<string>() { "Step1", "Step2" }));
                tasks.Add(new Task("Task4", new DateTime(2012, 9, 3), DateTime.Now, true, new List<string>() { "Step1", "Step2", "Step3" }));
                tasks.Add(new Task("Task5", new DateTime(2012, 7, 15), new DateTime(2012, 9, 23), false, new List<string>() { }));
                tasks.Add(new Task("Task6", new DateTime(2012, 4, 3), new DateTime(2012, 4, 2), true, new List<string>() { "Step1", "Step2", "Step3", "Step4" }));
                tasks.Add(new Task("Task7", new DateTime(2012, 9, 3), DateTime.Now, false, new List<string>() { "Step1", "Step2", "Step3" }));
                return tasks;
            }
        }
    }
}
