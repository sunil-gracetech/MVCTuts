using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTuts.Contract.Request
{
    public class customerviewmodel
    {
        public string name { get; set; }
        public string email { get; set; }
        public long mobile { get; set; }
        public string pass { get; set; }
        [Display( Name ="Your hobbies")]
        public bool chk { get; set; }
    }
}