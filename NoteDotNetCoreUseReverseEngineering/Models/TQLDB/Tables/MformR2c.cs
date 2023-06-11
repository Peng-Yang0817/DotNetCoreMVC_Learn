using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformR2c
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public double? 博士班 { get; set; }

    public double? 碩士班 { get; set; }

    public double? 碩士在職專班 { get; set; }

    public double? 四技日間部高職生 { get; set; }

    public double? 四技日間部高中生 { get; set; }

    public double? 四技進修部 { get; set; }

    public double? 四技在職專班 { get; set; }

    public double? 二技日間部 { get; set; }

    public double? 二技進修部 { get; set; }

    public double? 進修學院 { get; set; }

    public double? 二專日間部 { get; set; }

    public double? 二專夜間部 { get; set; }

    public double? 二專在職專班 { get; set; }

    public double? 進修專校 { get; set; }

    public double? 五專 { get; set; }

    public double? Total { get; set; }
}
