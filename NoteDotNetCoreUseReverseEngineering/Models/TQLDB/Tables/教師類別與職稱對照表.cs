using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class 教師類別與職稱對照表
{
    public int Id { get; set; }

    public string? 專兼任 { get; set; }

    public string? 任職狀態 { get; set; }

    public string? 教師分類 { get; set; }

    public string? 列計職級 { get; set; }

    public string? 統稱 { get; set; }

    public string? 類別 { get; set; }

    public string? 職稱 { get; set; }

    public bool Tt1131 { get; set; }

    public bool Tt1132 { get; set; }
}
