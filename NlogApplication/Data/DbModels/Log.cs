using System;
using System.Collections.Generic;

namespace NlogApplication.Data.DbModels;

public partial class Log
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? Level { get; set; }

    public string? Message { get; set; }

    public string? StackTrace { get; set; }

    public string? Exception { get; set; }

    public string? Logger { get; set; }

    public string? Url { get; set; }
}
