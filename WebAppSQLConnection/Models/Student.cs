﻿namespace WebAppSQLConnection.Models
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
