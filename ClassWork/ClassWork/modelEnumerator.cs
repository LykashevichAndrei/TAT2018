using System.Collections;

namespace ClassWork
{
    class modelEnumerator : IEnumerator
    {
        Car[] car;
        int position = 0;
        public modelEnumerator(Car[] list)
        {
            car = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < car.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Car Current
        {
            get
            {
                return car[position];
            }
        }
    }
}
