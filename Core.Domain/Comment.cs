using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime TimeOfComment { get; } //Moet zelf worden vastgesteld door het systeem
        public Role CommentBy { get; } //Moet zelf worden vastgesteld door eht systeem + Role moet nog employee worden etc
        public Visibility Visibility { get; set; }
    }
}
