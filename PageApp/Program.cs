using System;
using System.Collections.Generic;

namespace UserApp
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Listar usuários");
                Console.WriteLine("3 - Sair");
            }
        }      
    }
}
