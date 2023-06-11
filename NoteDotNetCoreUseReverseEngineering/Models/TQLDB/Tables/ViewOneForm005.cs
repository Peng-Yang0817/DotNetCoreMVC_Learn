﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewOneForm005
{
    public int Id { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public string Year { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string Tclnum { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public int State011Id { get; set; }

    public string State011Name { get; set; } = null!;

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C5 { get; set; } = null!;

    public string C6 { get; set; } = null!;

    public int? State018Id { get; set; }

    public string State018Name { get; set; } = null!;

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? OneFormUploadId { get; set; }

    public string? FileName { get; set; }

    public DateTime? FileUploadTime { get; set; }

    public string? C3 { get; set; }

    public string? C4 { get; set; }

    public string? C7 { get; set; }

    public string C8 { get; set; } = null!;
}
