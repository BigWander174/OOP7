namespace OOP7.SubApplications.Moving.Model
{
    internal class PhysicsQuantities
    {
        private double _startSpeed;
        private double _acceleration;
        private double _time;

        public double Speed => _startSpeed + _acceleration * _time;
        public double Distance
        {
            get
            {

                return _startSpeed * _time + _acceleration * _time * _time / 2;
            }
        } 

        public void Set(string startSpeed, string acceleration, string time)
        {
            try
            {
                _startSpeed = double.Parse(startSpeed);
                _acceleration = double.Parse(acceleration);
                _time = double.Parse(time);
            }
            catch (FormatException)
            {
                _startSpeed = 0;
                _acceleration = 0;
                _time = 0;
            }
        }
    }
}
