namespace PortalRandkowy.API.Dtos
{
    public class UserForUpdateDto
    {
        // Zakładka Info

        public string Height { get; set; }
        public string EyeColor { get; set; }
        public string HairColour { get; set; }
        public string MartialStatus { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Children { get; set; }
        public string Languages { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // Zakładka O mnie

        public string Motto { get; set; }
        public string Description { get; set; }
        public string Personality { get; set; }
        public string LookingFor { get; set; }


        // Zakładka Pasje, zainteresowania

        public string Interests { get; set; }
        public string FreeTime { get; set; }
        public string Sport { get; set; }
        public string Movies { get; set; }
        public string Music { get; set; }

        // Zakładka Preferencje

        public string ILike { get; set; }
        public string IdoNotLike { get; set; }
        public string MakesMeLaugh { get; set; }
        public string ItFeelsBestIn { get; set; }
        public string FriendsWouldDescribeMe { get; set; }

    }
}