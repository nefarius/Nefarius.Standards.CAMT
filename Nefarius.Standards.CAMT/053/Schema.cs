using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Nefarius.Standards.CAMT._053;

[XmlRoot(ElementName = "MsgRcpt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class MsgRcpt
{
    [XmlElement(ElementName = "Nm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Nm { get; set; }
}

[XmlRoot(ElementName = "GrpHdr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class GrpHdr
{
    [XmlElement(ElementName = "MsgId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string MsgId { get; set; }

    [XmlElement(ElementName = "CreDtTm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime CreDtTm { get; set; }

    [XmlElement(ElementName = "MsgRcpt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public MsgRcpt MsgRcpt { get; set; }
}

[XmlRoot(ElementName = "Id", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Id
{
    [XmlElement(ElementName = "IBAN", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string IBAN { get; set; }
}

[XmlRoot(ElementName = "FinInstnId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class FinInstnId
{
    [XmlElement(ElementName = "BIC", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string BIC { get; set; }
}

[XmlRoot(ElementName = "Svcr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Svcr
{
    [XmlElement(ElementName = "FinInstnId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public FinInstnId FinInstnId { get; set; }
}

[XmlRoot(ElementName = "Acct", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Acct
{
    [XmlElement(ElementName = "Id", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Id Id { get; set; }

    [XmlElement(ElementName = "Ccy", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Ccy { get; set; }

    [XmlElement(ElementName = "Svcr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Svcr Svcr { get; set; }
}

[XmlRoot(ElementName = "CdOrPrtry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class CdOrPrtry
{
    [XmlElement(ElementName = "Cd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Cd { get; set; }
}

[XmlRoot(ElementName = "Tp", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Tp
{
    [XmlElement(ElementName = "CdOrPrtry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public CdOrPrtry CdOrPrtry { get; set; }
}

[XmlRoot(ElementName = "Amt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Amt
{
    [XmlAttribute(AttributeName = "Ccy", Namespace = "")]
    public string Ccy { get; set; }

    [XmlText] public decimal Text { get; set; }
}

[XmlRoot(ElementName = "Dt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Date
{
    [XmlElement(ElementName = "Dt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime Dt { get; set; }

    [XmlElement(ElementName = "DtTm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime DtTm { get; set; }
}

[XmlRoot(ElementName = "Bal", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Bal
{
    [XmlElement(ElementName = "Tp", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Tp Tp { get; set; }

    [XmlElement(ElementName = "Amt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Amt Amt { get; set; }

    [XmlElement(ElementName = "CdtDbtInd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string CdtDbtInd { get; set; }

    [XmlElement(ElementName = "Dt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Date Date { get; set; }
}

[XmlRoot(ElementName = "BookgDt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class BookgDt
{
    [XmlElement(ElementName = "Dt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime Dt { get; set; }
}

[XmlRoot(ElementName = "ValDt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class ValDt
{
    [XmlElement(ElementName = "Dt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime Dt { get; set; }
}

[XmlRoot(ElementName = "Fmly", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Fmly
{
    [XmlElement(ElementName = "Cd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Cd { get; set; }

    [XmlElement(ElementName = "SubFmlyCd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string SubFmlyCd { get; set; }
}

[XmlRoot(ElementName = "Domn", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Domn
{
    [XmlElement(ElementName = "Cd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Cd { get; set; }

    [XmlElement(ElementName = "Fmly", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Fmly Fmly { get; set; }
}

[XmlRoot(ElementName = "Prtry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Prtry
{
    [XmlElement(ElementName = "Cd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public int Cd { get; set; }

    [XmlElement(ElementName = "Issr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Issr { get; set; }
}

[XmlRoot(ElementName = "BkTxCd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class BkTxCd
{
    [XmlElement(ElementName = "Domn", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Domn Domn { get; set; }

    [XmlElement(ElementName = "Prtry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Prtry Prtry { get; set; }
}

[XmlRoot(ElementName = "Btch", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Btch
{
    [XmlElement(ElementName = "PmtInfId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string PmtInfId { get; set; }

    [XmlElement(ElementName = "NbOfTxs", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public int NbOfTxs { get; set; }
}

[XmlRoot(ElementName = "Refs", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Refs
{
    [XmlElement(ElementName = "TxId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string TxId { get; set; }

    [XmlElement(ElementName = "EndToEndId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string EndToEndId { get; set; }
}

[XmlRoot(ElementName = "InstdAmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class InstdAmt
{
    [XmlElement(ElementName = "Amt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Amt Amt { get; set; }
}

[XmlRoot(ElementName = "TxAmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class TxAmt
{
    [XmlElement(ElementName = "Amt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Amt Amt { get; set; }
}

[XmlRoot(ElementName = "AmtDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class AmtDtls
{
    [XmlElement(ElementName = "InstdAmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public InstdAmt InstdAmt { get; set; }

    [XmlElement(ElementName = "TxAmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public TxAmt TxAmt { get; set; }
}

[XmlRoot(ElementName = "PstlAdr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class PstlAdr
{
    [XmlElement(ElementName = "Ctry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Ctry { get; set; }
}

[XmlRoot(ElementName = "Dbtr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Dbtr
{
    [XmlElement(ElementName = "Nm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Nm { get; set; }

    [XmlElement(ElementName = "PstlAdr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public PstlAdr PstlAdr { get; set; }
}

[XmlRoot(ElementName = "DbtrAcct", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class DbtrAcct
{
    [XmlElement(ElementName = "Id", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Id Id { get; set; }
}

[XmlRoot(ElementName = "RltdPties", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class RltdPties
{
    [XmlElement(ElementName = "Dbtr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Dbtr Dbtr { get; set; }

    [XmlElement(ElementName = "DbtrAcct", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DbtrAcct DbtrAcct { get; set; }

    [XmlElement(ElementName = "UltmtDbtr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public UltmtDbtr UltmtDbtr { get; set; }
}

[XmlRoot(ElementName = "DbtrAgt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class DbtrAgt
{
    [XmlElement(ElementName = "FinInstnId", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public FinInstnId FinInstnId { get; set; }
}

[XmlRoot(ElementName = "RltdAgts", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class RltdAgts
{
    [XmlElement(ElementName = "DbtrAgt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DbtrAgt DbtrAgt { get; set; }
}

[XmlRoot(ElementName = "CdtrRefInf", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class CdtrRefInf
{
    [XmlElement(ElementName = "Tp", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Tp Tp { get; set; }

    [XmlElement(ElementName = "Ref", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Ref { get; set; }
}

[XmlRoot(ElementName = "Strd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Strd
{
    [XmlElement(ElementName = "CdtrRefInf", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public CdtrRefInf CdtrRefInf { get; set; }
}

[XmlRoot(ElementName = "RmtInf", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class RmtInf
{
    [XmlElement(ElementName = "Strd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Strd Strd { get; set; }

    [XmlElement(ElementName = "Ustrd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Ustrd { get; set; }
}

[XmlRoot(ElementName = "TxDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class TxDtls
{
    [XmlElement(ElementName = "Refs", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Refs Refs { get; set; }

    [XmlElement(ElementName = "AmtDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public AmtDtls AmtDtls { get; set; }

    [XmlElement(ElementName = "RltdPties", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public RltdPties RltdPties { get; set; }

    [XmlElement(ElementName = "RltdAgts", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public RltdAgts RltdAgts { get; set; }

    [XmlElement(ElementName = "RmtInf", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public RmtInf RmtInf { get; set; }
}

[XmlRoot(ElementName = "UltmtDbtr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class UltmtDbtr
{
    [XmlElement(ElementName = "Nm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Nm { get; set; }
}

[XmlRoot(ElementName = "NtryDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class NtryDtls
{
    [XmlElement(ElementName = "Btch", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Btch Btch { get; set; }

    [XmlElement(ElementName = "TxDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public List<TxDtls> TxDtls { get; set; }
}

[XmlRoot(ElementName = "Ntry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Ntry
{
    [XmlElement(ElementName = "NtryRef", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string NtryRef { get; set; }

    [XmlElement(ElementName = "Amt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Amt Amt { get; set; }

    [XmlElement(ElementName = "CdtDbtInd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string CdtDbtInd { get; set; }

    [XmlElement(ElementName = "RvslInd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public bool RvslInd { get; set; }

    [XmlElement(ElementName = "Sts", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Sts { get; set; }

    [XmlElement(ElementName = "BookgDt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public BookgDt BookgDt { get; set; }

    [XmlElement(ElementName = "ValDt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public ValDt ValDt { get; set; }

    [XmlElement(ElementName = "AcctSvcrRef", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string AcctSvcrRef { get; set; }

    [XmlElement(ElementName = "BkTxCd", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public BkTxCd BkTxCd { get; set; }

    [XmlElement(ElementName = "NtryDtls", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public NtryDtls NtryDtls { get; set; }
}

[XmlRoot(ElementName = "Stmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Stmt
{
    [XmlElement(ElementName = "Id", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string Id { get; set; }

    [XmlElement(ElementName = "ElctrncSeqNb", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public int ElctrncSeqNb { get; set; }

    [XmlElement(ElementName = "LglSeqNb", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public string LglSeqNb { get; set; }

    [XmlElement(ElementName = "CreDtTm", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public DateTime CreDtTm { get; set; }

    [XmlElement(ElementName = "Acct", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Acct Acct { get; set; }

    [XmlElement(ElementName = "Bal", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public List<Bal> Bal { get; set; }

    [XmlElement(ElementName = "Ntry", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Ntry Ntry { get; set; }
}

[XmlRoot(ElementName = "BkToCstmrStmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class BkToCstmrStmt
{
    [XmlElement(ElementName = "GrpHdr", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public GrpHdr GrpHdr { get; set; }

    [XmlElement(ElementName = "Stmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public Stmt Stmt { get; set; }
}

/// <summary>
///     ISO 20022 Account Statement camt.053 version 2
/// </summary>
/// <remarks>Bank to Customer Statement</remarks>
[XmlRoot(ElementName = "Document", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
public class Document
{
    [XmlElement(ElementName = "BkToCstmrStmt", Namespace = "ISO:camt.053.001.02:APC:STUZZA:payments:003")]
    public BkToCstmrStmt BkToCstmrStmt { get; set; }

    [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
    public string Xmlns { get; set; }

    [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string Xsi { get; set; }

    [XmlText] public string Text { get; set; }

    /// <summary>
    ///     Deserializes from a <see cref="Stream" />.
    /// </summary>
    /// <param name="stream">The source stream.</param>
    /// <returns>The deserialized document.</returns>
    public static Document Deserialize(Stream stream)
    {
        return Deserialize(XDocument.Load(stream));
    }

    /// <summary>
    ///     Deserializes from a file path.
    /// </summary>
    /// <param name="uri">The source file path.</param>
    /// <returns>The deserialized document.</returns>
    public static Document Deserialize(string uri)
    {
        return Deserialize(XDocument.Load(uri));
    }

    private static Document Deserialize(XDocument doc)
    {
        if (doc.Root is null)
        {
            throw new ArgumentNullException(nameof(doc));
        }

        XmlReader reader = doc.Root.CreateReader();

        XmlSerializer xmlSerializer = new(typeof(Document));
        return (Document)xmlSerializer.Deserialize(reader);
    }
}