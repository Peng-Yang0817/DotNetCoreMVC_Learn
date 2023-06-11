﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform203b
{
    public int Year { get; set; }

    public string? Semester { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string? Campus { get; set; }

    public string? BuildingName { get; set; }

    public string? Status { get; set; }

    public string? FinishDate { get; set; }

    public string? UseLicense { get; set; }

    public string? SafeSituation { get; set; }

    public string? Ownership { get; set; }

    public string? Rent { get; set; }

    public double? AreaNum { get; set; }

    public string? EditNote { get; set; }

    public string? Note { get; set; }
}
