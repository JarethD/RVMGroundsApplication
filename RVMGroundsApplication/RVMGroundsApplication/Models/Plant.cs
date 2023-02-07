using System;
using System.Collections.Generic;
namespace RVMGroundsApplication.Models
{
    class Plant
    {
        string commonName { get; set; }
        string latinName { get; set; }
        string description { get; set; }
        string pruning { get; set; }
        List<string> monthsToPrune { get; set; }
    }
}