using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class 採計職級對照表
{
    public int Id { get; set; }

    public string? 專兼任 { get; set; }

    public string? 聘書職級 { get; set; }

    public string? 證書職級 { get; set; }

    public string? 列計職級 { get; set; }

    public bool Tt1121 { get; set; }

    public bool Tt1122 { get; set; }
}
