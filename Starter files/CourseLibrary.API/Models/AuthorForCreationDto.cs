﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CourseLibrary.API.Models
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTimeOffset DateOfBirth { get; set; }
        public string MainCategory { get; set; } = string.Empty;
        public ICollection<CourseForCreationDto> Cources { get; set; }
            = new List<CourseForCreationDto>();
    }
}
