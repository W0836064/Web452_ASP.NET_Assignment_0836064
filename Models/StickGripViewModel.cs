using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Megha_Stick.Models
{
    public class StickGripViewModel
    {
        public List<Stick> Sticks { get; set; }
        public SelectList GripTypes { get; set; }
        public string SelectedGripType { get; set; }
        public string SearchString { get; set; }
    }
}
