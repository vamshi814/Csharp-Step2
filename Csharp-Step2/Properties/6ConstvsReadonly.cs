using System;


// constant:
//static - accessed by all instances
//const value never changes
//must be initialized at declaration

//ReadOnly:
//value may set at declaration or in constructor
//non static - allows different value per instance

class _6ConstvsReadonly
{
    const double PI = 3.14;

    readonly int aadhar;
    public _6ConstvsReadonly()
    {
        aadhar = 1111111;

    }

}

