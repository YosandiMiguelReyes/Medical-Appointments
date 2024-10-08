﻿using MedicalAppointment.Domain.Core.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointment.Domain.Core.User
{
    public abstract class BaseUser : BaseEntity
    {
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

    }
}
