using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class EmailLog
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK Auth001 收件人 Id
    /// </summary>
    public int Auth001Id { get; set; }

    /// <summary>
    /// EMail Subject 標題
    /// </summary>
    public string EmailSubject { get; set; } = null!;

    /// <summary>
    /// EMail Body 內容
    /// </summary>
    public string Body { get; set; } = null!;

    /// <summary>
    /// EMail Bcc 隱藏收件者 ( 寄件者 )
    /// </summary>
    public string? ToBcc { get; set; }

    /// <summary>
    /// 有附件 就填入  1
    /// </summary>
    public int? HaveAtt { get; set; }

    /// <summary>
    /// 程式寄出Mail的時間
    /// </summary>
    public DateTime? MailTimestamp { get; set; }

    /// <summary>
    /// 程式判斷是否已經寄過 (1:已寄出)
    /// </summary>
    public int? IsSendMail { get; set; }

    /// <summary>
    /// 郵件伺服器回應時間
    /// </summary>
    public DateTime? MailServerTimestamp { get; set; }

    /// <summary>
    /// 郵件伺服器回應該信寄出是否成功(1:成功)
    /// </summary>
    public int? MailServerStatus { get; set; }

    /// <summary>
    /// 郵件伺服器回應的錯誤訊息
    /// </summary>
    public string? MailServerErrorLog { get; set; }
}
