﻿namespace CleanArchitecture.Application.Common.DTO
{
    public class TodoItemDTO
    {
        public int Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public int Priority { get; set; }

        public string Note { get; set; }
    }
}
