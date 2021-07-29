using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrack.Common.Types
{
    public record Name
    {
        public Name(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        private Name() { }

        
        public string FirstName { get; init; }
        public string LastName { get; init; }
        [NotMapped]
        public string Initials { get { return GetInitials(); } }
        [NotMapped]
        public string FullName { get { return GetFullName(); } }

        private string GetInitials()
        {
            var sb = new StringBuilder();

            sb.Append(FirstName[0].ToString().ToUpperInvariant());
            sb.Append(LastName[0].ToString().ToUpperInvariant());

            return sb.ToString();
        }

        private string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
