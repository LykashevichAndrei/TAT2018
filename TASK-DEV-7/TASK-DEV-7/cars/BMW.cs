namespace TASK_DEV_7
{
    /// <summary>
    /// BMW Car
    /// </summary>
    public class BMW : Car
    {
        public BMW(string Mark, string Model, string Bodytype, string Transmissiontype, string Enginetype, string Amount, string Power, string Climate, string Carinterior)
        {
            model = Model;
            mark = Mark;
            bodytype = Bodytype;
            transmissiontype = Transmissiontype;
            enginetype = Enginetype;
            amount = Amount;
            power = Power;
            climate = Climate;
            carinterior = Carinterior;
        }
    }
}
