using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCCalculator.Models
{
    public class CalculatorViewModel
    {
        [Display(Name = "First Number")]
        public double Num1 { get; set; }

        [Display(Name = "Second Number")]
        public double Num2 { get; set; }

        public string Operation { get; set; }

        public string Message { get; set; }
    }
}
