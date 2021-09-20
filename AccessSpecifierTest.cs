using System;
namespace  CoreCSharp_Concepts
{

    class A {
        int i=10;
        private class B {

        }
    }

    class B {
        A a= new A();
        Console.WriteLine("test");
    }
    
}

