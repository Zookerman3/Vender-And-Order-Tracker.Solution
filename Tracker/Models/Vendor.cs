using System.Collections.Generic;


namespace Tracker.Models
{
    public class Vendor
    {
         public string Name { get; set; }
    
    public Vendor(string vendorName)
    {
        Name = vendorName;
    }
    }
}