using System.Collections.Generic;

namespace MVCContact.Models
{
    public class HomeViewModel
    {
        public List<ContactModel> Contacts { get; set; }

        public List<MeetingModel> Meetings { get; set; }
    }
}
