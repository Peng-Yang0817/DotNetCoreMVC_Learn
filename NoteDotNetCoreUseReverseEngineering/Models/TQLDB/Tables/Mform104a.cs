using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform104a
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// 學期
    /// </summary>
    public string Semester { get; set; } = null!;

    /// <summary>
    /// 校基庫學校代碼
    /// </summary>
    public string SchoolNum { get; set; } = null!;

    /// <summary>
    /// 學校名稱
    /// </summary>
    public string SchoolName { get; set; } = null!;

    /// <summary>
    /// 系所代碼
    /// </summary>
    public string DepartmentNum { get; set; } = null!;

    /// <summary>
    /// 系所名稱
    /// </summary>
    public string DepartmentName { get; set; } = null!;

    /// <summary>
    /// 碩、博士班-博士班-A1文法商管教
    /// </summary>
    public double? PhDa1 { get; set; }

    /// <summary>
    /// 碩、博士班-博士班-A2理醫
    /// </summary>
    public double? PhDa2 { get; set; }

    /// <summary>
    /// 碩、博士班-博士班-A3工藝農
    /// </summary>
    public double? PhDa3 { get; set; }

    /// <summary>
    /// 碩、博士班-日間碩士班-A1文法商管教
    /// </summary>
    public double? MasterA1 { get; set; }

    /// <summary>
    /// 碩、博士班-日間碩士班-A2理醫
    /// </summary>
    public double? MasterA2 { get; set; }

    /// <summary>
    /// 碩、博士班-日間碩士班-A3工藝農
    /// </summary>
    public double? MasterA3 { get; set; }

    /// <summary>
    /// 碩、博士班-碩士在職專班-A1文法商管教
    /// </summary>
    public double? OjtmasterA1 { get; set; }

    /// <summary>
    /// 碩、博士班-碩士在職專班-A2理醫
    /// </summary>
    public double? OjtmasterA2 { get; set; }

    /// <summary>
    /// 碩、博士班-碩士在職專班-A3工藝農
    /// </summary>
    public double? OjtmasterA3 { get; set; }

    /// <summary>
    /// 大學部-日間二技-B1文法商管教
    /// </summary>
    public double? ErJiRiJianB1 { get; set; }

    /// <summary>
    /// 大學部-日間二技-B2理醫
    /// </summary>
    public double? ErJiRiJianB2 { get; set; }

    /// <summary>
    /// 大學部-日間二技-B3工藝農
    /// </summary>
    public double? ErJiRiJianB3 { get; set; }

    /// <summary>
    /// 大學部-日間四技-B1文法商管教
    /// </summary>
    public double? SiJiRiJianB1 { get; set; }

    /// <summary>
    /// 大學部-日間四技-B2理醫
    /// </summary>
    public double? SiJiRiJianB2 { get; set; }

    /// <summary>
    /// 大學部-日間四技-B3工藝農
    /// </summary>
    public double? SiJiRiJianB3 { get; set; }

    /// <summary>
    /// 大學部-進修部二技-B1文法商管教
    /// </summary>
    public double? ErJiJinXiuB1 { get; set; }

    /// <summary>
    /// 大學部-進修部二技-B2理醫
    /// </summary>
    public double? ErJiJinXiuB2 { get; set; }

    /// <summary>
    /// 大學部-進修部二技-B3工藝農
    /// </summary>
    public double? ErJiJinXiuB3 { get; set; }

    /// <summary>
    /// 大學部-進修部四技-B1文法商管教
    /// </summary>
    public double? SiJiJinXiuB1 { get; set; }

    /// <summary>
    /// 大學部-進修部四技-B2理醫
    /// </summary>
    public double? SiJiJinXiuB2 { get; set; }

    /// <summary>
    /// 大學部-進修部四技-B3工藝農
    /// </summary>
    public double? SiJiJinXiuB3 { get; set; }

    /// <summary>
    /// 大學部-進修學院-B1文法商管教
    /// </summary>
    public double? JiJinXiuYuanB1 { get; set; }

    /// <summary>
    /// 大學部-進修學院-B2理醫
    /// </summary>
    public double? JiJinXiuYuanB2 { get; set; }

    /// <summary>
    /// 大學部-進修學院-B3工藝農
    /// </summary>
    public double? JiJinXiuYuanB3 { get; set; }

    /// <summary>
    /// 大學部-四技在職專班-B1文法商管教
    /// </summary>
    public double? SiJiZaiZhiZhuanBanB1 { get; set; }

    /// <summary>
    /// 大學部-四技在職專班-B2理醫
    /// </summary>
    public double? SiJiZaiZhiZhuanBanB2 { get; set; }

    /// <summary>
    /// 大學部-四技在職專班-B3工藝農
    /// </summary>
    public double? SiJiZaiZhiZhuanBanB3 { get; set; }

    /// <summary>
    /// 專科部-日間二專-C1商護語
    /// </summary>
    public double? ErZhuanRiJianC1 { get; set; }

    /// <summary>
    /// 專科部-日間二專-C2醫藥家藝
    /// </summary>
    public double? ErZhuanRiJianC2 { get; set; }

    /// <summary>
    /// 專科部-日間二專-C3工農海
    /// </summary>
    public double? ErZhuanRiJianC3 { get; set; }

    /// <summary>
    /// 專科部-日間五專-C1商護語
    /// </summary>
    public double? WuZhuanRiJianC1 { get; set; }

    /// <summary>
    /// 專科部-日間五專-C2醫藥家藝
    /// </summary>
    public double? WuZhuanRiJianC2 { get; set; }

    /// <summary>
    /// 專科部-日間五專-C3工農海
    /// </summary>
    public double? WuZhuanRiJianC3 { get; set; }

    /// <summary>
    /// 專科部-夜間部二專-C1商護語
    /// </summary>
    public double? ErZhuanYeJianC1 { get; set; }

    /// <summary>
    /// 專科部-夜間部二專-C2醫藥家藝
    /// </summary>
    public double? ErZhuanYeJianC2 { get; set; }

    /// <summary>
    /// 專科部-夜間部二專-C3工農海
    /// </summary>
    public double? ErZhuanYeJianC3 { get; set; }

    /// <summary>
    /// 專科部-進修專校-C1商護語
    /// </summary>
    public double? JinXiuZhuanXiaoC1 { get; set; }

    /// <summary>
    /// 專科部-進修專校-C2醫藥家藝
    /// </summary>
    public double? JinXiuZhuanXiaoC2 { get; set; }

    /// <summary>
    /// 專科部-進修專校-C3工農海
    /// </summary>
    public double? JinXiuZhuanXiaoC3 { get; set; }

    /// <summary>
    /// 專科部-二專在職專班-C1商護語
    /// </summary>
    public double? ZaiZhiZhuanC1 { get; set; }

    /// <summary>
    /// 專科部-二專在職專班-C2醫藥家藝
    /// </summary>
    public double? ZaiZhiZhuanC2 { get; set; }

    /// <summary>
    /// 專科部-二專在職專班-C3工農海
    /// </summary>
    public double? ZaiZhiZhuanC3 { get; set; }

    /// <summary>
    /// 修改項目
    /// </summary>
    public string? EditNote { get; set; }

    /// <summary>
    /// 修改說明
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// 修改時間
    /// </summary>
    public DateTime EditTime { get; set; }
}
