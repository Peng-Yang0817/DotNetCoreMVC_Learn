﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform105b
{
    public int Id { get; set; }

    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string? Degree { get; set; }

    public string? DiJiNian { get; set; }

    public string? Categy { get; set; }

    public int? InSchoolStudent { get; set; }

    public int? ShiXiXueShengShu { get; set; }

    public int? ShiXiXueFenShu { get; set; }

    public int? BiYeZongXueFenShu { get; set; }

    public string? ConvertStudent { get; set; }

    public double? ConvertUpperLimit { get; set; }

    public string? Kelieji { get; set; }

    public string EditNote { get; set; } = null!;

    public string Note { get; set; } = null!;
}
