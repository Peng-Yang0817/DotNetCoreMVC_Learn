﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform208b
{
    public int Year { get; set; }

    public string? Semester { get; set; }

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public double? AreaNum { get; set; }
}
