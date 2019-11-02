using System;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
