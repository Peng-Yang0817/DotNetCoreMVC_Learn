using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform205b
{
    public int Year { get; set; }

    public string? Semester { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string? BuildingName { get; set; }

    public string? Notarization { get; set; }

    public string? NotarizationNum { get; set; }

    public string? Contract { get; set; }

    public string? ContractStart { get; set; }

    public string? ContractEnd { get; set; }

    public double? AreaNum { get; set; }

    public string? EditNote { get; set; }

    public string? Note { get; set; }
}
