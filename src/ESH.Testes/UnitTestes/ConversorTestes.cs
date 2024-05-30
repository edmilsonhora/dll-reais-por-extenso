using ESH.ReaisPorExtenso;
using ESH.ReaisPorExtenso.Interfaces;
using System;

namespace ESH.Testes.UnitTestes
{
    public class ConversorTestes
    {
        [Fact(DisplayName = "Ao passar valor zero deve lançar exception")]
        public void Teste1()
        {
            IConversor sut = new Conversor();

            var result = Assert.Throws<ArgumentException>(() => sut.ConverteParaExtenso(0));

            Assert.Equal("Valor não suportado para conversão", result.Message);

        }

        [Fact(DisplayName = "Ao passar valor negativo deve lançar exception")]
        public void Teste2()
        {
            IConversor sut = new Conversor();

            var result = Assert.Throws<ArgumentException>(() => sut.ConverteParaExtenso(-2m));

            Assert.Equal("Valor não suportado para conversão", result.Message);

        }

        [Fact(DisplayName = "Ao passar valor superior ao limite maximo deve lançar exception")]
        public void Teste3()
        {
            IConversor sut = new Conversor();

            var result = Assert.Throws<ArgumentException>(() => sut.ConverteParaExtenso(1000000000000000m));

            Assert.Equal("Valor não suportado para conversão", result.Message);

        }

        [Fact(DisplayName = "Ao passar valor 10 deve converter")]
        public void Teste4()
        {
            IConversor sut = new Conversor();

            var result = sut.ConverteParaExtenso(10m);

            Assert.Equal("DEZ REAIS", result);

        }

        [Fact(DisplayName = "Ao passar valor 10,50 deve converter")]
        public void Teste5()
        {
            IConversor sut = new Conversor();

            var result = sut.ConverteParaExtenso(10.50m);

            Assert.Equal("DEZ REAIS E CINQUENTA CENTAVOS", result);

        }

        [Fact(DisplayName = "Ao passar valor 35,28 deve converter")]
        public void Teste6()
        {
            IConversor sut = new Conversor();

            var result = sut.ConverteParaExtenso(35.28m);

            Assert.Equal("TRINTA E CINCO REAIS E VINTE E OITO CENTAVOS", result);

        }
    }
}
