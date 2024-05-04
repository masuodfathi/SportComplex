using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportComplex.Models
{
    public class Team
    {
        public string TeamName { get; set; } //نام تیم
        public string CoachName { get; set; } //نام مربی
        public string Sprot_Type { get; set; } //نوع ورزش 
        public string DressColor { get; set; } //رنگ لباس 
        public string Training_Salon { get; set; } //سالن تمرین 
        public string Training_Days { get; set; } //روزهای تمرین 
        public int NumAthlete { get; set; } //تعداد ورزشکار 
        public int rank { get; set; } //رتبه تیم
        public string LeagueName { get; set; } //نام لیگ
        public string Sponsor { get; set; } //حامی مالی
        public string Numchampionship { get; set; } //تعداد قهرمانی
        public int ID_Team { get; set; } //آیدی
        public float Budget { get; set; } //بودجه تیم
        public string PhysicianName { get; set; } //نام پزشک تیم
        public int Foundation_Year { get; set; } //سال تاسیس تیم
        public int Num_NationalPlayer { get; set; } //تعداد بازیکن خارجی

    }
}
