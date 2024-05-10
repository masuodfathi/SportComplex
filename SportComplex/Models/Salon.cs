using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportComplex.Models
{
    public class Salon
    {
        public string Salon { get; set; } //نام سالن  
        public string Type { get; set; } //نوع سالن
        public float WorkingDay { get; set; } //روزهای کاری   
        public float Closing_Time { get; set; } //ساعت بسته شدن 
        public string Address { get; set; } //آدرس
        public int Courses { get; set; } //تعداد دوره های آموزشی
        public float Meterage { get; set; } //متراژ یا مساحت
        public string Repair_Status { get; set; }//وضعیت تعمیر
        public int ID_Salon { get; set; } //آیدی
        public bool Have_LockerRoom { get; set; } //داشتن یا نداشتن رختکن
        public string Manager { get; set; } //مسئول سالن
        public bool IsCleaned { get; set; } //تمیز بودن یا نبودن
        public bool Have_Insurance { get; set; } //وضعیت بیمه
        public int Build_Year { get; set; } //سال ساخت
        public bool Have_Buffet { get; set; } //داشتن یا نداشتن بوفه 

    }
}
