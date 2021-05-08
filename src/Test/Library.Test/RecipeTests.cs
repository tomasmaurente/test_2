using NUnit.Framework;
using Full_GRASP_And_SOLID.Library;

namespace Library.Test
{
    public class RecipeTests
    {
        private Recipe recetaDePizza;
        private Product harina;
        private Step batir;
        private Equipment horno;

        [SetUp]
        public void Setup()
        {
            // Arrange
            this.recetaDePizza = new Recipe();
            this.harina = new Product("harina",1);
            this.horno = new Equipment("horno",120);
            this.batir = new Step(harina,1,horno,1);
        }

        [Test]
        public void GetTextToPrintTest() // Cambiá el nombre para indicar qué estás probando
        {
            // Arrange
            string strHechoAMano = "Receta de Pizza:\n 1 de harina usando horno durante 1\nCosto de producción: 121";
            // Act
            recetaDePizza.AddStep(batir);
            // Assert
            Assert.AreEqual(recetaDePizza.GetTextToPrint(),strHechoAMano);
        }

        [Test]
        public void GetCostTest() // Cambiá el nombre para indicar qué estás probando
        {
            // Arrange
            double calcAMano = 121;
            // Act
            recetaDePizza.AddStep(batir);
            // Assert
            Assert.AreEqual(recetaDePizza.GetProductionCost(),calcAMano);
        }
    }
}