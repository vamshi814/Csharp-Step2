using System;

namespace family
{
    class Parent
    {
        public string ParentName { get; set; }
        public void ShowParentMsg()
        {
            Console.WriteLine($"This is {ParentName} from Parent class!");
        }
        public Parent(string name,string parent)
        {
            this.ParentName = parent;
            Console.WriteLine("Parent construcctor");
            Console.WriteLine($"Father {parent} - Son {name}");
        }
    }
    class Child : Parent
    {
        public string ChildName {  get; set; }
        public void ShowChildMsg()
        {
            var thisChild = this;
            Console.WriteLine($"Hello I'm {thisChild.ParentName} the Parent from child class");
            Console.WriteLine($"Hello I'm {thisChild.ChildName} the Child from child class");
            Console.WriteLine($"This is {ChildName} from Child class!");
            Console.WriteLine($"Hi my parent is {base.ParentName} from child method");
            Console.WriteLine(this);
        }
        public Child(string name,string parent): base(name,parent)
        {
            Console.WriteLine("Child Constructor");
        }
    }

    class IMain
    {
        static void Main()
        {
            //Child c1 = new Child("jr john","sr John");
            //c1.ChildName = "Jr Robert";
            ////c1.ShowParentMsg();
            //c1.ShowChildMsg();


            Parent p1 = new Child("Sambaji", "Shivaji");
        }

    }



}
