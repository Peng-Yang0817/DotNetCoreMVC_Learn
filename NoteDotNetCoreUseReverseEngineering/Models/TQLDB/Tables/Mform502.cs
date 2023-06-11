using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform502
{
    public long? 序號 { get; set; }

    public int 學年度 { get; set; }

    public string 校基庫代碼 { get; set; } = null!;

    public string 學校名稱 { get; set; } = null!;

    public string 系所代碼 { get; set; } = null!;

    public string 學程學院名稱 { get; set; } = null!;

    public double 在學博士班 { get; set; }

    public double 在學日間碩士班 { get; set; }

    public double 在學碩士在職專班 { get; set; }

    public double 在學日間學士班 { get; set; }

    public double 在學進修學士班 { get; set; }

    public double 在學日間五專 { get; set; }

    public double 在學日間二專 { get; set; }

    public double 在學進修二專 { get; set; }

    public double 延畢博士班 { get; set; }

    public double 延畢日間碩士班 { get; set; }

    public double 延畢碩士在職專班 { get; set; }

    public double 延畢日間學士班 { get; set; }

    public double 延畢進修學士班 { get; set; }

    public double 延畢日間五專 { get; set; }

    public double 延畢日間二專 { get; set; }

    public double 延畢進修二專 { get; set; }

    public int? 現職教授 { get; set; }

    public int? 現職副教授 { get; set; }

    public int? 現職助理教授 { get; set; }

    public int? 現職講師 { get; set; }

    public int? 部派護理老師 { get; set; }

    public int? 護理臨床指導教師 { get; set; }

    public int? 本學程主聘教師數 { get; set; }
}
