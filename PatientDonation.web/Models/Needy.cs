using System.ComponentModel.DataAnnotations;

namespace PatientDonation.web.Models
{
    public class Needy
    {
        [Key]
        public int Needy_Id { get; set; }



        public string? Name { get; set; }

        public string? CNIC { get; set; }

        public string? Disease { get; set; }

        public string? Donation_Demanded { get; set; }

        public string? Donation_Received { get; set; }

        public List<Donar>? Donars { get; set; }
    }
}
