using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class EmailAttLog
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK EMailLog
    /// </summary>
    public int EmailLogId { get; set; }

    /// <summary>
    /// 附件檔案名稱
    /// </summary>
    public string? Fname { get; set; }

    /// <summary>
    /// 附件內容
    /// </summary>
    public byte[]? Fdata { get; set; }

    /// <summary>
    /// 附件時間
    /// </summary>
    public DateTime AttTimestamp { get; set; }
}
