

namespace RasketsRime.Models.DTOs;

public class EventCreationDTO
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int VenueId { get; set; }

    public string EventName { get; set; }
    public int ExpectedAttendees { get; set; }

    public string EventDescription { get; set; }
    public bool IsPublic { get; set; }
      public DateTime? SubmitedOn { get; set; }

    public string Status { get; set; }

    public DateTime EventStart { get; set; }
    public int Duration { get; set; }
    public List<int> ServiceIds { get; set; } = new List<int>();
    
    
    
    

      
}


