using System.Collections;

namespace ClassWork
{
    class UniqueModelsEnumerator :IEnumerator
    {
        Car[] car;
        int position = -1;
        public UniqueModelsEnumerator(Car[] list)
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
