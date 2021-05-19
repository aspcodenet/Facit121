using System;

namespace Facit121
{
    class ProgramHej
    {
        public static void Main(string[] args)
        {
            var l = new FunkDemos();
            l.Run();

            var labbar = new StringLabbar();
            labbar.Run();

            var demos111 = new Demos();
            demos111.Run();


            var demo20120517 = new Demos20210517();
            demo20120517.Run();



            var looparLabbar = new  LooparLabbar();
            looparLabbar.Lab7();
            looparLabbar.Lab6a();
            looparLabbar.Lab6b();



            var demo = new Demos();
            demo.Run();

            Console.WriteLine("321132312");


            var helloWorld = new HelloWorld();
            //HelloWorld.Run123();
            helloWorld.Run123();
            
            //var variabelLabbar = new VariabelLabbar();
            //variabelLabbar.Run();


            var ifLabbar = new IfLabbar();
            ifLabbar.Run();


            var funktionsLabbar = new FunktionsLabbar();

            string theMessage = funktionsLabbar.PrintMessage();

            //funktionsLabbar.Lab2();
            funktionsLabbar.Run();


        }
    }
}
