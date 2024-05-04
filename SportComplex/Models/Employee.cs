using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportComplex.Models
{
    public class Employee

    {
        public string FirstName { get; set; } //نام
        public string LastName { get; set; } //نام خانوادگی
        public int Age { get; set; } //سن
        public string Position { get; set; } //مقام 
        public string EducationDegree { get; set; } //مدرک تحصیلی
        public string WorkingField { get; set; } //زمینه کاری
        public int ID_Employee { get; set; } //آیدی
        public int Phone { get; set; } //تلفن
        public string HomeAddress { get; set; } //آدرس منزل
        public bool IsMarried { get; set; } //وضعیت تأهل
        public int NumChildren { get; set; } //تعداد فرزندان
        public float Income { get; set; } //درآمد
        public int Num_WorkLeave { get; set; } //تعداد مرخصی
        public int Finishing_Time { get; set; } //ساعت اتمام کار




    }
}
