using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nlog
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Name { get; set; }

    public string? ClientIp { get; set; }

    public string? Message { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Level { get; set; }

    public string? Host { get; set; }

    public string? Type { get; set; }

    public string? Source { get; set; }

    public string? Logger { get; set; }

    public string? Stacktrace { get; set; }

    public string? Detail { get; set; }
}
