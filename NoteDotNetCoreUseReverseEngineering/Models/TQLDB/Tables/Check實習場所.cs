using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check實習場所
{
    public int Id { get; set; }

    public string 實習場所 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public bool Tt472學校附屬機構實習一般生採計 { get; set; }

    /// <summary>
    /// 學校附屬機構實習延畢生採計
    /// </summary>
    public bool Tt472學校附屬機構實習延畢生採計 { get; set; }

    /// <summary>
    /// 全學年校外實習學生數一般生採計
    /// </summary>
    public bool Tt472全學年校外實習學生數一般生採計 { get; set; }

    /// <summary>
    /// 全學年校外實習學生數一般生採計
    /// </summary>
    public bool Tt472全學年校外實習學生數延畢生採計 { get; set; }

    /// <summary>
    /// 部分學分校外實習學生數一般生採計
    /// </summary>
    public bool Tt472部分學分校外實習學生數一般生採計 { get; set; }

    /// <summary>
    /// 部分學分校外實習學生數延畢生採計
    /// </summary>
    public bool Tt472部分學分校外實習學生數延畢生採計 { get; set; }
}
