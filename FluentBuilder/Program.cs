using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Email.Builder
                .To("usu.courses@gmail.com")
                .From("chugaev1998@gmail.com")
                .Cc("example@example.com")
                .Subject("Homework")
                .Content("it's my third homework")
                .Result;
        }
    }
}