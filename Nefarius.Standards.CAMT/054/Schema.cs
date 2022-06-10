using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Nefarius.Standards.CAMT._054;
// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(Document));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (Document)serializer.Deserialize(reader);
// }

[XmlRoot(ElementName = "MsgRcpt")]
public class MsgRcpt
{
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }
}

[XmlRoot(ElementName = "GrpHdr")]
public class GrpHdr
{
    [XmlElement(ElementName = "MsgId")]
    public double MsgId { get; set; }

    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }

    [XmlElement(ElementName = "MsgRcpt")]
    public MsgRcpt MsgRcpt { get; set; }
}

[XmlRoot(ElementName = "Id")]
public class Id
{
    [XmlElement(ElementName = "IBAN")]
    public string IBAN { get; set; }
}

[XmlRoot(ElementName = "Ownr")]
public class Ownr
{
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }
}

[XmlRoot(ElementName = "FinInstnId")]
public class FinInstnId
{
    [XmlElement(ElementName = "BIC")]
    public string BIC { get; set; }
}

[XmlRoot(ElementName = "Svcr")]
public class Svcr
{
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}

[XmlRoot(ElementName = "Acct")]
public class Acct
{
    [XmlElement(ElementName = "Id")]
    public Id Id { get; set; }

    [XmlElement(ElementName = "Ccy")]
    public string Ccy { get; set; }

    [XmlElement(ElementName = "Ownr")]
    public Ownr Ownr { get; set; }

    [XmlElement(ElementName = "Svcr")]
    public Svcr Svcr { get; set; }
}

[XmlRoot(ElementName = "Amt")]
public class Amt
{
    [XmlAttribute(AttributeName = "Ccy")]
    public string Ccy { get; set; }

    [XmlText]
    public int Text { get; set; }
}

[XmlRoot(ElementName = "BookgDt")]
public class BookgDt
{
    [XmlElement(ElementName = "Dt")]
    public DateTime Dt { get; set; }
}

[XmlRoot(ElementName = "ValDt")]
public class ValDt
{
    [XmlElement(ElementName = "Dt")]
    public DateTime Dt { get; set; }
}

[XmlRoot(ElementName = "Fmly")]
public class Fmly
{
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }

    [XmlElement(ElementName = "SubFmlyCd")]
    public string SubFmlyCd { get; set; }
}

[XmlRoot(ElementName = "Domn")]
public class Domn
{
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }

    [XmlElement(ElementName = "Fmly")]
    public Fmly Fmly { get; set; }
}

[XmlRoot(ElementName = "Prtry")]
public class Prtry
{
    [XmlElement(ElementName = "Cd")]
    public int Cd { get; set; }

    [XmlElement(ElementName = "Issr")]
    public string Issr { get; set; }
}

[XmlRoot(ElementName = "BkTxCd")]
public class BkTxCd
{
    [XmlElement(ElementName = "Domn")]
    public Domn Domn { get; set; }

    [XmlElement(ElementName = "Prtry")]
    public Prtry Prtry { get; set; }
}

[XmlRoot(ElementName = "Refs")]
public class Refs
{
    [XmlElement(ElementName = "TxId")]
    public string TxId { get; set; }

    [XmlElement(ElementName = "EndToEndId")]
    public double EndToEndId { get; set; }
}

[XmlRoot(ElementName = "TxAmt")]
public class TxAmt
{
    [XmlElement(ElementName = "Amt")]
    public Amt Amt { get; set; }
}

[XmlRoot(ElementName = "AmtDtls")]
public class AmtDtls
{
    [XmlElement(ElementName = "TxAmt")]
    public TxAmt TxAmt { get; set; }
}

[XmlRoot(ElementName = "PstlAdr")]
public class PstlAdr
{
    [XmlElement(ElementName = "Ctry")]
    public string Ctry { get; set; }

    [XmlElement(ElementName = "AdrLine")]
    public string AdrLine { get; set; }
}

[XmlRoot(ElementName = "Dbtr")]
public class Dbtr
{
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElement(ElementName = "PstlAdr")]
    public PstlAdr PstlAdr { get; set; }
}

[XmlRoot(ElementName = "DbtrAcct")]
public class DbtrAcct
{
    [XmlElement(ElementName = "Id")]
    public Id Id { get; set; }
}

[XmlRoot(ElementName = "Cdtr")]
public class Cdtr
{
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }

    [XmlElement(ElementName = "PstlAdr")]
    public PstlAdr PstlAdr { get; set; }
}

[XmlRoot(ElementName = "RltdPties")]
public class RltdPties
{
    [XmlElement(ElementName = "Dbtr")]
    public Dbtr Dbtr { get; set; }

    [XmlElement(ElementName = "DbtrAcct")]
    public DbtrAcct DbtrAcct { get; set; }

    [XmlElement(ElementName = "Cdtr")]
    public Cdtr Cdtr { get; set; }
}

[XmlRoot(ElementName = "DbtrAgt")]
public class DbtrAgt
{
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}

[XmlRoot(ElementName = "RltdAgts")]
public class RltdAgts
{
    [XmlElement(ElementName = "DbtrAgt")]
    public DbtrAgt DbtrAgt { get; set; }
}

[XmlRoot(ElementName = "CdOrPrtry")]
public class CdOrPrtry
{
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }
}

[XmlRoot(ElementName = "Tp")]
public class Tp
{
    [XmlElement(ElementName = "CdOrPrtry")]
    public CdOrPrtry CdOrPrtry { get; set; }
}

[XmlRoot(ElementName = "CdtrRefInf")]
public class CdtrRefInf
{
    [XmlElement(ElementName = "Tp")]
    public Tp Tp { get; set; }

    [XmlElement(ElementName = "Ref")]
    public double Ref { get; set; }
}

[XmlRoot(ElementName = "Strd")]
public class Strd
{
    [XmlElement(ElementName = "CdtrRefInf")]
    public CdtrRefInf CdtrRefInf { get; set; }
}

[XmlRoot(ElementName = "RmtInf")]
public class RmtInf
{
    [XmlElement(ElementName = "Strd")]
    public Strd Strd { get; set; }
}

[XmlRoot(ElementName = "TxDtls")]
public class TxDtls
{
    [XmlElement(ElementName = "Refs")]
    public Refs Refs { get; set; }

    [XmlElement(ElementName = "AmtDtls")]
    public AmtDtls AmtDtls { get; set; }

    [XmlElement(ElementName = "RltdPties")]
    public RltdPties RltdPties { get; set; }

    [XmlElement(ElementName = "RltdAgts")]
    public RltdAgts RltdAgts { get; set; }

    [XmlElement(ElementName = "RmtInf")]
    public RmtInf RmtInf { get; set; }
}

[XmlRoot(ElementName = "NtryDtls")]
public class NtryDtls
{
    [XmlElement(ElementName = "TxDtls")]
    public List<TxDtls> TxDtls { get; set; }
}

[XmlRoot(ElementName = "Ntry")]
public class Ntry
{
    [XmlElement(ElementName = "Amt")]
    public Amt Amt { get; set; }

    [XmlElement(ElementName = "CdtDbtInd")]
    public string CdtDbtInd { get; set; }

    [XmlElement(ElementName = "Sts")]
    public string Sts { get; set; }

    [XmlElement(ElementName = "BookgDt")]
    public BookgDt BookgDt { get; set; }

    [XmlElement(ElementName = "ValDt")]
    public ValDt ValDt { get; set; }

    [XmlElement(ElementName = "AcctSvcrRef")]
    public string AcctSvcrRef { get; set; }

    [XmlElement(ElementName = "BkTxCd")]
    public BkTxCd BkTxCd { get; set; }

    [XmlElement(ElementName = "NtryDtls")]
    public NtryDtls NtryDtls { get; set; }
}

[XmlRoot(ElementName = "Ntfctn")]
public class Ntfctn
{
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }

    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }

    [XmlElement(ElementName = "Acct")]
    public Acct Acct { get; set; }

    [XmlElement(ElementName = "Ntry")]
    public Ntry Ntry { get; set; }
}

[XmlRoot(ElementName = "BkToCstmrDbtCdtNtfctn")]
public class BkToCstmrDbtCdtNtfctn
{
    [XmlElement(ElementName = "GrpHdr")]
    public GrpHdr GrpHdr { get; set; }

    [XmlElement(ElementName = "Ntfctn")]
    public List<Ntfctn> Ntfctn { get; set; }
}

[XmlRoot(ElementName = "Document")]
public class Document
{
    [XmlElement(ElementName = "BkToCstmrDbtCdtNtfctn")]
    public BkToCstmrDbtCdtNtfctn BkToCstmrDbtCdtNtfctn { get; set; }

    [XmlAttribute(AttributeName = "xmlns")]
    public string Xmlns { get; set; }

    [XmlAttribute(AttributeName = "xsi")]
    public string Xsi { get; set; }

    [XmlText]
    public string Text { get; set; }
}