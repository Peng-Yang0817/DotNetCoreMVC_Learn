using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogOneForm001
{
    public string Atype { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string Year { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public int State011Id { get; set; }

    public int State012Id { get; set; }

    public int SchoolCtrl002Id { get; set; }

    public string DegreeName { get; set; } = null!;

    public int State013Id { get; set; }

    public int State014Id { get; set; }

    public string? State014Year { get; set; }

    public int State015Id { get; set; }

    public string Applicant1 { get; set; } = null!;

    public string Job1 { get; set; } = null!;

    public string Phone1 { get; set; } = null!;

    public string Email1 { get; set; } = null!;

    public string? Applicant2 { get; set; }

    public string? Job2 { get; set; }

    public string? Phone2 { get; set; }

    public string? Email2 { get; set; }

    public string? Applicant3 { get; set; }

    public string? Job3 { get; set; }

    public string? Phone3 { get; set; }

    public string? Email3 { get; set; }

    public double C1 { get; set; }

    public double C2 { get; set; }

    public double C3 { get; set; }

    public double C4 { get; set; }

    public string? OneFormUploadId { get; set; }

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public DateTime LogTime { get; set; }
}
