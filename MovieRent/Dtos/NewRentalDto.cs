using System.Collections.Generic;

namespace MovieRent.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }

        public List<int> MoviIds { get; set; }
    }
}