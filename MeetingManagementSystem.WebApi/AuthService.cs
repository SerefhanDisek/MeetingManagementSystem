using MediatR;
using MeetingManagementSystem.DataAccess.Models;

public class CreateMeetingCommand : IRequest<CreateMeetingResponse>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int RoomId { get; set; }
}

public class GetMeetingCommand : IRequest<Meeting>
{
    public int MeetingId { get; set; }
}

public class UpdateMeetingCommand : IRequest<UpdateMeetingResponse>
{
    public int MeetingId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int RoomId { get; set; }
}

public class DeleteMeetingCommand : IRequest
{
    public int MeetingId { get; set; }
}


