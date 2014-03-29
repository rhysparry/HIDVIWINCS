namespace HIDVIWINCS
{
    using System;

    public class DeviceStatus : IEquatable<DeviceStatus>
    {
        public bool Equals(DeviceStatus other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) ||
                                                     Equals(Red, other.Red) && Equals(Green, other.Green) &&
                                                     Equals(BlueYellow, other.BlueYellow));
        }

        public override bool Equals(object obj)
        {
            return !ReferenceEquals(null, obj) &&
                   (ReferenceEquals(this, obj) || obj.GetType() == this.GetType() && Equals((DeviceStatus) obj));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Red != null ? Red.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Green != null ? Green.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (BlueYellow != null ? BlueYellow.GetHashCode() : 0);
                return hashCode;
            }
        }

        public static bool operator ==(DeviceStatus left, DeviceStatus right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeviceStatus left, DeviceStatus right)
        {
            return !Equals(left, right);
        }

        public LightStatus Red { get; set; }
        public LightStatus Green { get; set; }
        public LightStatus BlueYellow { get; set; }
    }
}