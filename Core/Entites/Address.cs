﻿namespace Core.Entites
{
    public class Address : EntityBase 
    {
        public string Street { get; set; } = string.Empty;
        public string? City { get; set; }  
        public int Number { get; set; }
    }
}
