﻿namespace DoctorBookApp.Entities.Models.Abstract
{
    public abstract class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
