using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_JoshuaAllen_Team4_3.Model
{
    public class FormModel
    {
        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int assignment { get; set; }

        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int gproject { get; set; }

        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int quizzes { get; set; }

        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int midterm { get; set; }

        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int final { get; set; }

        [Range(1, 100, ErrorMessage = "Value Must Be Between 0 and 100")]
        public int intex { get; set; }

    }
}
