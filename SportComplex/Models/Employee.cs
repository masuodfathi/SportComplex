namespace SportComplex.Models
{
    public class Employee

    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public string EducationDegree { get; set; }

        public string WorkingField { get; set; }

        public string Phone { get; set; } // Changed to string to support longer phone numbers

        public string HomeAddress { get; set; }

        public bool IsMarried { get; set; }

        public int NumChildren { get; set; }

        public decimal Income { get; set; } // Changed to decimal for financial values

        public int NumWorkLeave { get; set; } // Changed to camelCase for convention

        public int FinishingTime { get; set; } // Changed to camelCase for convention





    }
}
