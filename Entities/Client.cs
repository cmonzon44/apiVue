using System;

namespace Entities
{
    public class Client
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Born { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public bool IsActive { get; set; }

        public Country Country { get; set; }
    }
}
