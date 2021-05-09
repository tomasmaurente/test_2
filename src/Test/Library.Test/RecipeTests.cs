using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class RecipeTests
    {
        private Recipe recetaDePizza;
        private Product pizza;
        private Product harina;
        private Step batir;
        private Equipment horno;
        

        [SetUp]
        public void Setup()
        {
            // Arrange
            this.recetaDePizza = new Recipe();
            this.pizza = new Product("Pizza",1);
            this.recetaDePizza.FinalProduct = pizza;
            this.harina = new Product("Harina", 1);
            this.horno = new Equipment("horno",120);
            this.batir = new Step(harina,1,horno,1);
        }

        [Test]
        // Chequeamos que se imprima correctamente la receta.
        public void GetTextToPrintTest() 
        {
            // Arrange
            string HandMade = "Receta de Pizza:\n1 de 'Harina' usando 'horno' durante 1\nCosto de producción: 121";
            // Act
            recetaDePizza.AddStep(batir);
            string MadeByFunction = recetaDePizza.GetTextToPrint();
            // Assert
            Assert.AreEqual(HandMade, MadeByFunction);
        }

        [Test]
        // Chequeamos que se calcule bien el costo total.
        public void GetCostTest() 
        {
            // Arrange
            double calcAMano = 121;
            // Act
            recetaDePizza.AddStep(batir);
            double calcByFuntion = recetaDePizza.GetProductionCost();
            // Assert
            Assert.AreEqual(calcAMano, calcByFuntion);
        }        
    }
}