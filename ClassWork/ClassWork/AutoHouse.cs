using System.Collections;

namespace ClassWork
{
    class AutoHouse : IEnumerable
    {
        private Car[] car;
        public AutoHouse(Car[] carlist)
        {
            car = new Car[carlist.Length];
            for(int i=0;i<carlist.Length;i++)
            {
                car[i] = carlist[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public carEnumerator GetEnumerator()
        {
            return new carEnumerator(car);
        }
    }
}
