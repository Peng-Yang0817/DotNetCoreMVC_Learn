using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform003
{
    /// <summary>
    /// Pk
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 學年度
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// FK State004Id 調整類型
    /// </summary>
    public int State004Id { get; set; }

    /// <summary>
    /// FK  SchoolCtrl001Id 學校代碼
    /// </summary>
    public int SchoolCtrl001Id { get; set; }

    /// <summary>
    /// 博士班
    /// </summary>
    public int ABoShiBanJqs { get; set; }

    /// <summary>
    /// 碩士班
    /// </summary>
    public int AShuoShiBanJqs { get; set; }

    /// <summary>
    /// 碩士在職專班
    /// </summary>
    public int AShuoShiZaiZhiZhuanBanJqs { get; set; }

    /// <summary>
    /// 四技日間部高職
    /// </summary>
    public int BSiJiRiJianBuGauJrJqs { get; set; }

    /// <summary>
    /// 四技日間部原內高中生
    /// </summary>
    public int BSiJiRiJianBuGauYuanNeiGaoZhongShengJqs { get; set; }

    /// <summary>
    /// 四技日間部原外加高中生
    /// </summary>
    public int BSiJiRiJianBuGauYuanWaiJiaGaoZhongShengJqs { get; set; }

    /// <summary>
    /// 四技進修部
    /// </summary>
    public int BSiJiJinXiuBuJqs { get; set; }

    /// <summary>
    /// 四技在職專班
    /// </summary>
    public int BSiJiZaiZhiZhuanBanJqs { get; set; }

    /// <summary>
    /// 二技日間部
    /// </summary>
    public int BErJiRiJianBuJqs { get; set; }

    /// <summary>
    /// 二技進修部
    /// </summary>
    public int BErJiJinXiuBuJqs { get; set; }

    /// <summary>
    /// 進修學院
    /// </summary>
    public int BErJiJinXiuXueYuanJqs { get; set; }

    /// <summary>
    /// 五專
    /// </summary>
    public int CWuZhuanJqs { get; set; }

    /// <summary>
    /// 二專日間部
    /// </summary>
    public int CErZhuanRiJianBuJqs { get; set; }

    /// <summary>
    /// 二專夜間部
    /// </summary>
    public int CErZhuanYeJianBuJqs { get; set; }

    /// <summary>
    /// 二專在職專班
    /// </summary>
    public int CErZhuanZaiZhiZhuanBanJqs { get; set; }

    /// <summary>
    /// 二專進修專校
    /// </summary>
    public int CErZhuanJinXiuZhuanXiaoJqs { get; set; }

    /// <summary>
    /// 核定文號
    /// </summary>
    public string? DocNum { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? UserNote { get; set; }

    /// <summary>
    /// FK Auth001 填寫者
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// 紀錄時間
    /// </summary>
    public DateTime EditTime { get; set; }
}
