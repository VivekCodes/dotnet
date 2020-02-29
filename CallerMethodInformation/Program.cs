/*
    trying example from the guide below, with minor changes:
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/caller-information
*/


using System;

namespace CallerMethodInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.CallPrintCallerInformation();
        }

        public void CallPrintCallerInformation()
        {
            PrintCallerInformation("Message To Print.");
        }
        public void PrintCallerInformation(string message,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {            
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Member Name: " + memberName);
            Console.WriteLine("Source File Path: " + sourceFilePath);
            Console.WriteLine("Source Line Number: " + sourceLineNumber);
        }
    }
}
