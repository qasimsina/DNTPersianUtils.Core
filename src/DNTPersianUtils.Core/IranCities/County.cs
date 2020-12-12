using System.Collections.Generic;

namespace DNTPersianUtils.Core.IranCities
{
    /// <summary>
    /// Iran's County
    /// </summary>
    public class County
    {
        /// <summary>
        /// County Name
        /// </summary>
        public string CountyName { get; set; } = default!;

        /// <summary>
        /// Districts
        /// </summary>
        public ISet<District> Districts { get; } = new HashSet<District>();

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{CountyName}";
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is not County county)
                return false;

            return this.CountyName == county.CountyName;
        }

        /// <summary>
        /// GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + CountyName.GetHashCode();
                return hash;
            }
        }
    }
}