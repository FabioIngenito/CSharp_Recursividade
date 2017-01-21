using System;

/// <summary>
/// Antes de aprender recursividade, você precisa aprender recursividade...
/// 
/// Before learning recursion, you need to learn recursion ...
/// </summary>
namespace waRecursividade
{
    public class clsRecursividade
    {
        public Int32 Recursividade(Int32 intNumeroFinal)
        {
            int ant = 0;

            for (int i = 1; i <= intNumeroFinal; i++)
                ant = i + ant;

            return ant;
        }
    }
}
