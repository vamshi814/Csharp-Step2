using System;

// in interface every member is abstract so no need
//in abstract class , we must use abstract keyword for abstract methods(implemented later)

namespace AbstractionSystem
{


    abstract class MSG{
        //Abstract Properties
        public abstract int age { get; set; }

        //Abstract Methods
        public abstract void Msg();

        //Normal Methods
        public void getMsg()
        {
            Console.WriteLine("GetMsg");
        }

        // 0 or Param Cconstructors
        public MSG()
        {

        }
        public MSG(int age)
        {
            this.age = age;
        }

    }





}