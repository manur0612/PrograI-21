using System;

namespace appLaPiranha.Models
{
    public class CompraModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
