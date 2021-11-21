using System;

namespace TraderPanel.Core.Entites
{
    public class Plan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal TraderRate { get; set; }
        public decimal PanelRate { get; set; }
        public decimal CustomerRate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
