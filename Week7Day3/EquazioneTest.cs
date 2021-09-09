using System;
using Week7Day3.Core;
using Xunit;

namespace Week7Day3
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();
            
            //ACT: chista  alle funzionalità da testare
            var risultato = equazione.RisolviEquazioneSecondoGrado(1, -3, 2);

            //ASSERT: Verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]); //alternativa Assert.True(risultato[0] ==1);
            Assert.Equal(2, risultato[1]);
        
        
        }
        [Fact]
        public void Test2()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();

            //ACT: chista  alle funzionalità da testare
            var risultato = equazione.RisolviEquazioneSecondoGrado(1, -5, 6);

            //ASSERT: Verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]); //alternativa Assert.True(risultato[0] ==1);
            Assert.Equal(3, risultato[1]);


        }
        [Fact]
        public void Test3()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();

            //ACT: chista  alle funzionalità da testare
            var risultato = equazione.RisolviEquazioneSecondoGrado(1, 2, 1);

            //ASSERT: Verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(-1, risultato[0]); //alternativa Assert.True(risultato[0] ==1);
            Assert.Equal(-1, risultato[1]);


        }
        [Fact]
        public void Test4()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();

            //ACT: chista  alle funzionalità da testare
            var risultato = equazione.RisolviEquazioneSecondoGrado(1, -3, 10);

            //ASSERT: Verifica del risultato
            Assert.True(risultato == null);
            
            //Assert.Null(risultato);



        }
    }
}
