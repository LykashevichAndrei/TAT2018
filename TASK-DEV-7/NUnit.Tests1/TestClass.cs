using NUnit.Framework;
using System.Collections.Generic;
using TASK_DEV_7;
using TASK_DEV_7.creators;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase( @"{
                'mark': 'BMW',
    'model': 'D1',
    'bodytype': 'compartment',
    'transmissiontype': 'Automatic',
    'enginetype': 'electro',
    'amount': 4,
    'power': 120,
    'climate': 'СlimateСontrol',
    'carinterior': 'leather'
  }")]
        public void TestJSONDeserialize(string Object)
        {
            List<Car> CompareModel = new List<Car>();
            BMWCreator model = new BMWCreator();
            CompareModel.Add(model.Create("BMW","D1","compartment","Automatic","eletro","4","120","ClimateControl","leather"));
            JSONDeserialize test = new JSONDeserialize(Object);
            BMWCreator compare = new BMWCreator();
            List<Car> Model = new List<Car>();
           Model=test.Deserialize();
            Assert.AreEqual(Model, CompareModel);
        }
    }
}
