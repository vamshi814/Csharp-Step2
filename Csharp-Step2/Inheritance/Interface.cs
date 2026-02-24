namespace InterfaceBasics
{
    interface Interface1
    {
        //by default in interface every member is public
        string Name { get; set; }
        int age { get; set; }
        string getName();

        int getAge();

        string getMsg();

    }
    interface Interface3 { 
        string getLoc();
    }
    interface Interface2 : Interface1 , Interface3
    {
        string getEmpList();
    }   
}
