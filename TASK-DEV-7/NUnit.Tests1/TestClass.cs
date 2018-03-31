using NUnit.Framework;
using System.Collections.Generic;
using TASK_DEV_7;
using TASK_DEV_7.creators;
using Moq;

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
        [TestCase(@"{
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
        public void TestFind(string result)
        {
            JSONDeserialize test = new JSONDeserialize(result);
            List < Car > list= new List<Car>();
            BMW car1 = new BMW("BMW", "D2", "compartment", "Automatic", "eletro", "4", "120", "ClimateControl", "leather");
            BMW car2 = new BMW("BMW", "D1", "compartment", "Automatic", "eletro", "4", "120", "ClimateControl", "leather");
            BMW car3 = new BMW("BMW", "D3", "compartment", "Automatic", "eletro", "4", "120", "ClimateControl", "leather");
            List<Car> catalog = new List<Car>();
            catalog.Add(car1);
            catalog.Add(car2);
            catalog.Add(car3);
            list = test.Deserialize();
            int i=0;
            foreach (EnteredCar element in list)
            {
                FindCar findcar = new FindCar(catalog,element);
               i= findcar.Find();
            }
            Assert.AreEqual(2, i);
        }
    }
}
