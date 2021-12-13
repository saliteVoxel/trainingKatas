namespace MarsRoverGuided
{
    public class Coordinates
    {
        private readonly string _coordinates;

        public Coordinates(string coordinates)
        {
            _coordinates = coordinates;
        }

        protected bool Equals(Coordinates other)
        {
            return _coordinates == other._coordinates;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Coordinates) obj);
        }

        public override int GetHashCode()
        {
            return _coordinates.GetHashCode();
        }
    }
}