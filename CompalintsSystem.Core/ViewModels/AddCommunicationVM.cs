﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CompalintsSystem.Core.ViewModels
{
    public class AddCommunicationVM
    {

        public int Id { get; set; }
        public string reportSubmitterId { get; set; }
        public string reportSubmitterName { get; set; }
        public string reporteeName { get; set; }
        public string BenfPhoneNumber { get; set; }
        public int CollegesId { get; set; }

        public int DepartmentsId { get; set; }

        public int SubDepartmentsId { get; set; }


        [Required(ErrorMessage = "يجب ان تقوم بإختيار نوع البلاغ ")]
        public string TypeCommuncationId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "يجب ان تقوم بكتابة العنوان  ")]
        public string Titile { get; set; }
        public string reason { get; set; }

    }
}