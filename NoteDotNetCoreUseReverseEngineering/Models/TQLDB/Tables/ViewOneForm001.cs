﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneForm001
{
    public string Id { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public int State011Id { get; set; }

    public string State011Name { get; set; } = null!;

    public int State012Id { get; set; }

    public string State012Name { get; set; } = null!;

    public int SchoolCtrl002Id { get; set; }

    public string CollegeName { get; set; } = null!;

    public string DegreeName { get; set; } = null!;

    public int State013Id { get; set; }

    public string State013Name { get; set; } = null!;

    public int State014Id { get; set; }

    public string State014Name { get; set; } = null!;

    public string? State014Year { get; set; }

    public int State015Id { get; set; }

    public string State015Name { get; set; } = null!;

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

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? OneFormUploadId { get; set; }

    public string? FileName { get; set; }

    public DateTime? FileUploadTime { get; set; }

    public int? EditAuth001Id { get; set; }
}
