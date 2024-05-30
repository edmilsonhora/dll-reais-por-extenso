using System;

namespace ESH.ReaisPorExtenso.Interfaces
{
    /// <summary>
    /// Interface para conversor
    /// </summary>
    public interface IConversor
    {
        /// <summary>
        /// metodo que faz a conversao de valor para extenso
        /// </summary>
        /// <param name="valor">valor para conversao</param>
        /// <returns> string com o valor por extenso</returns>
        /// <exception cref="ArgumentException"></exception>
        string ConverteParaExtenso(decimal valor);
    }
}
