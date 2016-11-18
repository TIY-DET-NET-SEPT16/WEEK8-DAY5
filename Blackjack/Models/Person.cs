using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blackjack.Models
{
    public class Person
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
    }
}