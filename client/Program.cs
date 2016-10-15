using System;
using System.Threading;

namespace client
{
    class variants
    {
        public int variant;
        public int var
        {
            get
            {
                return variant;
            }
        }
    }
    class client
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your ip:");
            string ip = Console.ReadLine();
            Console.WriteLine("Enter your port:");
            var port = Convert.ToInt32(Console.ReadLine());
            variants vars = new variants();

            var client = new Server.Clibibl();

            while (true)
            {

                Console.WriteLine("2)Time or 3) to exit");
                vars.variant = Convert.ToInt32(Console.ReadLine());

               
                if (vars.var == 2)
                {
                    Console.WriteLine(client.download(variant));
                }
                if (vars.var == 3)
                {
                    break;
                }
            }

        }

    }
}
