using System;

namespace appLaPiranha.Models
{
    public class VentaModels
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
