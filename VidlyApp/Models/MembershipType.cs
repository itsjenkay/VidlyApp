using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public byte DurationsInMonth { get; set; }

        public byte DiscountRate { get; set; }

        public short SignUpFee { get; set; }

        public static readonly byte Unkwon = 0;

        public static readonly byte PayAsYouGo = 1;


    }
}