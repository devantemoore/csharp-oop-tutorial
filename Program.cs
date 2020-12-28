using System;

namespace csharp_oop_tutorial
{
    public class Parent{
        public static int publicInt;
        internal static int internalInt;
        private static int privateInt = 0;

        static Parent(){
            
            // Child1 child = new Child1();
            // child.publicInt = 2; // would throw an error: Can't access prop (static)
            Child1.publicInt = 1;
            Child1.internalInt = 2;
            Child2.publicInt = 1;
            Child2.internalInt = 2;

            // can't access privateInt in either Child classes; only accessible within respective classes
        }

        public class Child1{
            public static int publicInt;
            internal static int internalInt;
            private static int privateInt = 0;
        }
        private class Child2{
            public static int publicInt;
            internal static int internalInt;
            private static int privateInt = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent.publicInt = 1; // Unlimited access.

            Parent.internalInt = 2; // Access limited to within assembly (project).

            // Parent.privateInt = 3; // Access limited to within Parent class.

            Parent.Child1.publicInt = 1; // Unlimited access.

            Parent.Child1.internalInt = 2; // Access limited to within assembly (project).

            // Parent.Child1.privateInt = 3 // Access limited to within Child1 class.

            // Parent.Child2.publicInt = 1; // Access limited to within Parent class.

            // Parent.Child2.internalInt = 2; // Access limited to within Parent class.

            // Parent.Child2.privateInt = 3; // Access limited to within Child2 class.
        }
    }
}
