﻿using System;

namespace GoogleApi
{
    public class SpreadsheetQuestion
    {
        public int RowNumber { get; set; }

        public string Id { get; set; }

        public string FrontendId { get; set; }

        public string Title { get; set; }

        public string Difficulty { get; set; }

        public string Status { get; set; }

        public int Frequency6Months { get; set; }

        public int Frequency1Year { get; set; }

        public int Frequency2Years { get; set; }

        public int FrequencyAllTime { get; set; }

        public string Slug { get; set; }

        public string Tags { get; set; }

        public string Companies { get; set; } = "";

        public DateTime? AddedDateTime { get; set; }

        public DateTime? LastSubmittedDateTime { get; set; }
        public int? DuplicatesCount { get; set; }
    }
}