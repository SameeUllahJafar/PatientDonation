

using System.ComponentModel.DataAnnotations.Schema;

namespace PatientDonation.web.Models
{
    public class Donar
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Donated_Amount { get; set; }

    
     
        public Needy? Needy { get; set; } // Navigation property
    }
}

