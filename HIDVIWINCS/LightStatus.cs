namespace HIDVIWINCS
{
    using System;

    public class LightStatus : IEquatable<LightStatus>
    {
        private byte _power;

        public bool Equals(LightStatus other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) ||
                                                     _power == other._power && State == other.State &&
                                                     OnDuty == other.OnDuty && OffDuty == other.OffDuty &&
                                                     Offset == other.Offset);
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) &&
                   (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((LightStatus) obj));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = _power.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) State;
                hashCode = (hashCode * 397) ^ OnDuty.GetHashCode();
                hashCode = (hashCode * 397) ^ OffDuty.GetHashCode();
                hashCode = (hashCode * 397) ^ Offset.GetHashCode();
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

        public LightState State { get; set; }

        public byte OnDuty { get; set; }

        public byte OffDuty { get; set; }

        public byte Offset { get; set; }

        public byte Power
        {
            get { return _power; }
            set { _power = value > 100 ? (byte)100 : value; }
        }
    }
}