namespace HIDVIWINCS
{
    using System;

    public class LightStatus : IEquatable<LightStatus>
    {
        public bool Equals(LightStatus other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) ||
                                                     _onDuty == other._onDuty && _offDuty == other._offDuty &&
                                                     _offset == other._offset &&
                                                     _power == other._power && State == other.State);
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) &&
                   (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && Equals((LightStatus) obj));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _onDuty;
                hashCode = (hashCode * 397) ^ _offDuty;
                hashCode = (hashCode * 397) ^ _offset;
                hashCode = (hashCode * 397) ^ _power;
                hashCode = (hashCode * 397) ^ (int) State;
                return hashCode;
            }
        }

        public static bool operator ==(LightStatus left, LightStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LightStatus left, LightStatus right)
        {
            return !Equals(left, right);
        }

        private int _onDuty;
        private int _offDuty;
        private int _offset;
        private int _power;
        public LightState State { get; set; }

        public int OnDuty
        {
            get { return _onDuty; }
            set { _onDuty = value < 0 ? 0 : value > 255 ? 255 : value; }
        }

        public int OffDuty
        {
            get { return _offDuty; }
            set { _offDuty = value < 0 ? 0 : value > 255 ? 255 : value; }
        }

        public int Offset
        {
            get { return _offset; }
            set { _offset = value < 0 ? 0 : value > 255 ? 255 : value; }
        }

        public int Power
        {
            get { return _power; }
            set { _power = value < 0 ? 0 : value > 100 ? 100 : value; }
        }
    }
}