﻿namespace Lab4.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Dept { get; set; } = string.Empty;
        public decimal Salary { get; set; }
    }
}
