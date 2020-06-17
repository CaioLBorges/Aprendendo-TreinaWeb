using System;
using System.Text;


namespace EstudandoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ABC";
            string string2 = "DEF";
            //PARA CONSTRUIR UMA STRING, CONCATENAÇÃO
            StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" ");
            sb.Append("GHI");

            Console.WriteLine(sb.ToString());

        }
    }
}
