using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class MformR2b
{
    public int Year { get; set; }

    public string Semester { get; set; } = null!;

    public string SchoolNum { get; set; } = null!;

    public string SchoolName { get; set; } = null!;

    public int? 博士班 { get; set; }

    public int? 碩士班 { get; set; }

    public int? 碩士在職專班 { get; set; }

    public int? 四技日間部高職生 { get; set; }

    public int? 四技日間部高中生 { get; set; }

    public int? 四技進修部 { get; set; }

    public int? 四技在職專班 { get; set; }

    public int? 二技日間部 { get; set; }

    public int? 二技進修部 { get; set; }

    public int? 進修學院 { get; set; }

    public int? 二專日間部 { get; set; }

    public int? 二專夜間部 { get; set; }

    public int? 二專在職專班 { get; set; }

    public int? 進修專校 { get; set; }

    public int? 五專 { get; set; }

    public int? Total { get; set; }
}
