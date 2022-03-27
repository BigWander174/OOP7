namespace OOP7.SubApplications.Pifagor.Model
{
    internal class PifagorModel
    {
        private double _part1;
        private double _part2;

        private double _gipo
        {
            get
            {
                if (_part1 == double.PositiveInfinity && _part2 == double.PositiveInfinity)
                {
                    return double.PositiveInfinity;
                }

                return Math.Sqrt(_part1 * _part1 + _part2 * _part2);
            }
        }

        public void Set(string first, string second)
        {
            try
            {
                _part1 = Convert.ToDouble(first);
                _part2 = Convert.ToDouble(second);
            }
            catch(FormatException)
            {
                SetNormalValues();
            }
        }

        public string GetInfo()
        {
            if (_gipo == double.PositiveInfinity)
            {
                return "Введены неверные данные";
            }

            return $"1й катет: {_part1}, 2й катет: {_part2}, гипотенуза: {_gipo}";
        }
        private void SetNormalValues()
        {
            _part1 = double.PositiveInfinity;
            _part2 = double.PositiveInfinity;
        }

    }
}
