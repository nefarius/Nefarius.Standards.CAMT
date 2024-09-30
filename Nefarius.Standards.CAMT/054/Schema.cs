#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Nefarius.Standards.CAMT._054;

/// <summary>
///     Message Recipient
/// </summary>
[XmlRoot(ElementName = "MsgRcpt")]
public class MsgRcpt
{
    /// <summary>
    ///     Name
    /// </summary>
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }
}

/// <summary>
///     Group Header
/// </summary>
[XmlRoot(ElementName = "GrpHdr")]
public class GrpHdr
{
    /// <summary>
    ///     Message Identification
    /// </summary>
    [XmlElement(ElementName = "MsgId")]
    public double MsgId { get; set; }

    /// <summary>
    ///     Creation Date Time
    /// </summary>
    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }

    /// <summary>
    ///     Message Recipient
    /// </summary>
    [XmlElement(ElementName = "MsgRcpt")]
    public MsgRcpt MsgRcpt { get; set; }
}

/// <summary>
///     Identification
/// </summary>
[XmlRoot(ElementName = "Id")]
public class Id
{
    /// <summary>
    ///     IBAN
    /// </summary>
    [XmlElement(ElementName = "IBAN")]
    public string IBAN { get; set; }
}

/// <summary>
///     Owner
/// </summary>
[XmlRoot(ElementName = "Ownr")]
public class Ownr
{
    /// <summary>
    ///     Name
    /// </summary>
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }

    /// <summary>
    ///     Postal Address
    /// </summary>
    [XmlElement(ElementName = "PstlAdr")]
    public string PstlAdr { get; set; }
}

/// <summary>
///     Financial Institution Identification
/// </summary>
[XmlRoot(ElementName = "FinInstnId")]
public class FinInstnId
{
    /// <summary>
    ///     BIC
    /// </summary>
    [XmlElement(ElementName = "BIC")]
    public string BIC { get; set; }
}

/// <summary>
///     Servicer
/// </summary>
[XmlRoot(ElementName = "Svcr")]
public class Svcr
{
    /// <summary>
    ///     Financial Institution Identification
    /// </summary>
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}

/// <summary>
///     Account
/// </summary>
[XmlRoot(ElementName = "Acct")]
public class Acct
{
    /// <summary>
    ///     Identification
    /// </summary>
    [XmlElement(ElementName = "Id")]
    public Id Id { get; set; }

    /// <summary>
    ///     Currency
    /// </summary>
    [XmlElement(ElementName = "Ccy")]
    public string Ccy { get; set; }

    /// <summary>
    ///     Owner
    /// </summary>
    [XmlElement(ElementName = "Ownr")]
    public Ownr Ownr { get; set; }

    /// <summary>
    ///     Servicer
    /// </summary>
    [XmlElement(ElementName = "Svcr")]
    public Svcr Svcr { get; set; }
}

/// <summary>
///     Amount
/// </summary>
[XmlRoot(ElementName = "Amt")]
public class Amt
{
    /// <summary>
    ///     Currency
    /// </summary>
    [XmlAttribute(AttributeName = "Ccy")]
    public string Ccy { get; set; }

    /// <summary>
    ///     Amount Value
    /// </summary>
    [XmlText]
    public decimal Value { get; set; }
}

/// <summary>
///     Booking Date
/// </summary>
[XmlRoot(ElementName = "BookgDt")]
public class BookgDt
{
    /// <summary>
    ///     Date
    /// </summary>
    [XmlElement(ElementName = "Dt")]
    public DateTime Dt { get; set; }
}

/// <summary>
///     Value Date
/// </summary>
[XmlRoot(ElementName = "ValDt")]
public class ValDt
{
    /// <summary>
    ///     Date
    /// </summary>
    [XmlElement(ElementName = "Dt")]
    public DateTime Dt { get; set; }
}

/// <summary>
///     Family
/// </summary>
[XmlRoot(ElementName = "Fmly")]
public class Fmly
{
    /// <summary>
    ///     Code
    /// </summary>
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }

    /// <summary>
    ///     Sub Family Code
    /// </summary>
    [XmlElement(ElementName = "SubFmlyCd")]
    public string SubFmlyCd { get; set; }
}

/// <summary>
///     Domain
/// </summary>
[XmlRoot(ElementName = "Domn")]
public class Domn
{
    /// <summary>
    ///     Code
    /// </summary>
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }

    /// <summary>
    ///     Family
    /// </summary>
    [XmlElement(ElementName = "Fmly")]
    public Fmly Fmly { get; set; }
}

/// <summary>
///     Proprietary
/// </summary>
[XmlRoot(ElementName = "Prtry")]
public class Prtry
{
    /// <summary>
    ///     Code
    /// </summary>
    [XmlElement(ElementName = "Cd")]
    public int Cd { get; set; }

    /// <summary>
    ///     Issuer
    /// </summary>
    [XmlElement(ElementName = "Issr")]
    public string Issr { get; set; }
}

/// <summary>
///     Bank Transaction Code
/// </summary>
[XmlRoot(ElementName = "BkTxCd")]
public class BkTxCd
{
    /// <summary>
    ///     Domain
    /// </summary>
    [XmlElement(ElementName = "Domn")]
    public Domn Domn { get; set; }

    /// <summary>
    ///     Proprietary
    /// </summary>
    [XmlElement(ElementName = "Prtry")]
    public Prtry Prtry { get; set; }
}

/// <summary>
///     References
/// </summary>
[XmlRoot(ElementName = "Refs")]
public class Refs
{
    /// <summary>
    ///     Transaction Identification
    /// </summary>
    [XmlElement(ElementName = "TxId")]
    public string TxId { get; set; }

    /// <summary>
    ///     End To End Identification
    /// </summary>
    [XmlElement(ElementName = "EndToEndId")]
    public double EndToEndId { get; set; }
}

/// <summary>
///     Transaction Amount
/// </summary>
[XmlRoot(ElementName = "TxAmt")]
public class TxAmt
{
    /// <summary>
    ///     Amount
    /// </summary>
    [XmlElement(ElementName = "Amt")]
    public Amt Amt { get; set; }
}

/// <summary>
///     Amount Details
/// </summary>
[XmlRoot(ElementName = "AmtDtls")]
public class AmtDtls
{
    /// <summary>
    ///     Transaction Amount
    /// </summary>
    [XmlElement(ElementName = "TxAmt")]
    public TxAmt TxAmt { get; set; }
}

/// <summary>
///     Postal Address
/// </summary>
[XmlRoot(ElementName = "PstlAdr")]
public class PstlAdr
{
    /// <summary>
    ///     Country
    /// </summary>
    [XmlElement(ElementName = "Ctry")]
    public string Ctry { get; set; }

    /// <summary>
    ///     Address Line
    /// </summary>
    [XmlElement(ElementName = "AdrLine")]
    public string AdrLine { get; set; }
}

/// <summary>
///     Debtor
/// </summary>
[XmlRoot(ElementName = "Dbtr")]
public class Dbtr
{
    /// <summary>
    ///     Name
    /// </summary>
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }

    /// <summary>
    ///     Postal Address
    /// </summary>
    [XmlElement(ElementName = "PstlAdr")]
    public PstlAdr PstlAdr { get; set; }
}

/// <summary>
///     Debtor Account
/// </summary>
[XmlRoot(ElementName = "DbtrAcct")]
public class DbtrAcct
{
    /// <summary>
    ///     Identification
    /// </summary>
    [XmlElement(ElementName = "Id")]
    public Id Id { get; set; }
}

/// <summary>
///     Creditor
/// </summary>
[XmlRoot(ElementName = "Cdtr")]
public class Cdtr
{
    /// <summary>
    ///     Name
    /// </summary>
    [XmlElement(ElementName = "Nm")]
    public string Nm { get; set; }

    /// <summary>
    ///     Postal Address
    /// </summary>
    [XmlElement(ElementName = "PstlAdr")]
    public PstlAdr PstlAdr { get; set; }
}

/// <summary>
///     Related Parties
/// </summary>
[XmlRoot(ElementName = "RltdPties")]
public class RltdPties
{
    /// <summary>
    ///     Debtor
    /// </summary>
    [XmlElement(ElementName = "Dbtr")]
    public Dbtr Dbtr { get; set; }

    /// <summary>
    ///     Debtor Account
    /// </summary>
    [XmlElement(ElementName = "DbtrAcct")]
    public DbtrAcct DbtrAcct { get; set; }

    /// <summary>
    ///     Creditor
    /// </summary>
    [XmlElement(ElementName = "Cdtr")]
    public Cdtr Cdtr { get; set; }
}

/// <summary>
///     Debtor Agent
/// </summary>
[XmlRoot(ElementName = "DbtrAgt")]
public class DbtrAgt
{
    /// <summary>
    ///     Financial Institution Identification
    /// </summary>
    [XmlElement(ElementName = "FinInstnId")]
    public FinInstnId FinInstnId { get; set; }
}

/// <summary>
///     Related Agents
/// </summary>
[XmlRoot(ElementName = "RltdAgts")]
public class RltdAgts
{
    /// <summary>
    ///     Debtor Agent
    /// </summary>
    [XmlElement(ElementName = "DbtrAgt")]
    public DbtrAgt DbtrAgt { get; set; }
}

/// <summary>
///     Code Or Proprietary
/// </summary>
[XmlRoot(ElementName = "CdOrPrtry")]
public class CdOrPrtry
{
    /// <summary>
    ///     Code
    /// </summary>
    [XmlElement(ElementName = "Cd")]
    public string Cd { get; set; }
}

/// <summary>
///     Type
/// </summary>
[XmlRoot(ElementName = "Tp")]
public class Tp
{
    /// <summary>
    ///     Code Or Proprietary
    /// </summary>
    [XmlElement(ElementName = "CdOrPrtry")]
    public CdOrPrtry CdOrPrtry { get; set; }
}

/// <summary>
///     Creditor Reference Information
/// </summary>
[XmlRoot(ElementName = "CdtrRefInf")]
public class CdtrRefInf
{
    /// <summary>
    ///     Type
    /// </summary>
    [XmlElement(ElementName = "Tp")]
    public Tp Tp { get; set; }

    /// <summary>
    ///     Reference
    /// </summary>
    [XmlElement(ElementName = "Ref")]
    public string Ref { get; set; }
}

/// <summary>
///     Structured
/// </summary>
[XmlRoot(ElementName = "Strd")]
public class Strd
{
    /// <summary>
    ///     Creditor Reference Information
    /// </summary>
    [XmlElement(ElementName = "CdtrRefInf")]
    public CdtrRefInf CdtrRefInf { get; set; }
}

/// <summary>
///     Remittance Information
/// </summary>
[XmlRoot(ElementName = "RmtInf")]
public class RmtInf
{
    /// <summary>
    ///     Structured
    /// </summary>
    [XmlElement(ElementName = "Strd")]
    public Strd Strd { get; set; }
}

/// <summary>
///     Transaction Details
/// </summary>
[XmlRoot(ElementName = "TxDtls")]
public class TxDtls
{
    /// <summary>
    ///     References
    /// </summary>
    [XmlElement(ElementName = "Refs")]
    public Refs Refs { get; set; }

    /// <summary>
    ///     Amount Details
    /// </summary>
    [XmlElement(ElementName = "AmtDtls")]
    public AmtDtls AmtDtls { get; set; }

    /// <summary>
    ///     Related Parties
    /// </summary>
    [XmlElement(ElementName = "RltdPties")]
    public RltdPties RltdPties { get; set; }

    /// <summary>
    ///     Related Agents
    /// </summary>
    [XmlElement(ElementName = "RltdAgts")]
    public RltdAgts RltdAgts { get; set; }

    /// <summary>
    ///     Remittance Information
    /// </summary>
    [XmlElement(ElementName = "RmtInf")]
    public RmtInf RmtInf { get; set; }
}

/// <summary>
///     Entry Details
/// </summary>
[XmlRoot(ElementName = "NtryDtls")]
public class NtryDtls
{
    /// <summary>
    ///     Transaction Details
    /// </summary>
    [XmlElement(ElementName = "TxDtls")]
    public List<TxDtls> TxDtls { get; set; }
}

/// <summary>
///     Entry
/// </summary>
[XmlRoot(ElementName = "Ntry")]
public class Ntry
{
    /// <summary>
    ///     Amount
    /// </summary>
    [XmlElement(ElementName = "Amt")]
    public Amt Amt { get; set; }

    /// <summary>
    ///     Credit Debit Indicator
    /// </summary>
    [XmlElement(ElementName = "CdtDbtInd")]
    public string CdtDbtInd { get; set; }

    /// <summary>
    ///     Status
    /// </summary>
    [XmlElement(ElementName = "Sts")]
    public string Sts { get; set; }

    /// <summary>
    ///     Booking Date
    /// </summary>
    [XmlElement(ElementName = "BookgDt")]
    public BookgDt BookgDt { get; set; }

    /// <summary>
    ///     Value Date
    /// </summary>
    [XmlElement(ElementName = "ValDt")]
    public ValDt ValDt { get; set; }

    /// <summary>
    ///     Account Servicer Reference
    /// </summary>
    [XmlElement(ElementName = "AcctSvcrRef")]
    public string AcctSvcrRef { get; set; }

    /// <summary>
    ///     Bank Transaction Code
    /// </summary>
    [XmlElement(ElementName = "BkTxCd")]
    public BkTxCd BkTxCd { get; set; }

    /// <summary>
    ///     Entry Details
    /// </summary>
    [XmlElement(ElementName = "NtryDtls")]
    public NtryDtls NtryDtls { get; set; }
}

/// <summary>
///     Notification
/// </summary>
[XmlRoot(ElementName = "Ntfctn")]
public class Ntfctn
{
    /// <summary>
    ///     Identification
    /// </summary>
    [XmlElement(ElementName = "Id")]
    public string Id { get; set; }

    /// <summary>
    ///     Creation Date Time
    /// </summary>
    [XmlElement(ElementName = "CreDtTm")]
    public DateTime CreDtTm { get; set; }

    /// <summary>
    ///     Account
    /// </summary>
    [XmlElement(ElementName = "Acct")]
    public Acct Acct { get; set; }

    /// <summary>
    ///     Entry
    /// </summary>
    [XmlElement(ElementName = "Ntry")]
    public Ntry Ntry { get; set; }
}

/// <summary>
///     Bank To Customer Debit Credit Notification
/// </summary>
[XmlRoot(ElementName = "BkToCstmrDbtCdtNtfctn")]
public class BkToCstmrDbtCdtNtfctn
{
    /// <summary>
    ///     Group Header
    /// </summary>
    [XmlElement(ElementName = "GrpHdr")]
    public GrpHdr GrpHdr { get; set; }

    /// <summary>
    ///     Notifications
    /// </summary>
    [XmlArray("Ntfctns")]
    [XmlArrayItem(typeof(Ntfctn), ElementName = "Ntfctn")]
    public List<Ntfctn> Ntfctns { get; set; }
}

/// <summary>
///     ISO 20022 Debit Notification camt.054 version 2
/// </summary>
[XmlRoot(ElementName = "Document", Namespace = "ISO:camt.054.001.02:APC:STUZZA:payments:003")]
public class Document
{
    /// <summary>
    ///     Bank To Customer Debit Credit Notification
    /// </summary>
    [XmlElement(ElementName = "BkToCstmrDbtCdtNtfctn")]
    public BkToCstmrDbtCdtNtfctn BkToCstmrDbtCdtNtfctn { get; set; }

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

        FixNotificationList(doc.Root);

        XmlReader reader = doc.Root.CreateReader();

        XmlSerializer xmlSerializer = new(typeof(Document));
        return (Document)xmlSerializer.Deserialize(reader);
    }

    /// <summary>
    ///     Fixes the problems in the source XML so it can be deserialized properly.
    /// </summary>
    /// <param name="node">The root node of the document.</param>
    private static void FixNotificationList(XElement node)
    {
        XNamespace docNs = "ISO:camt.054.001.02:APC:STUZZA:payments:003";

        XElement root = (XElement)node.FirstNode;

        if (root is null)
        {
            return;
        }

        XElement groupHeader = root.Nodes().OfType<XElement>().First(e => Equals(e.Name.LocalName, "GrpHdr"));

        List<XElement> notifications =
            root.Nodes().OfType<XElement>().Where(e => Equals(e.Name.LocalName, "Ntfctn")).ToList();

        XElement list = new(docNs + "Ntfctns", notifications);

        root.ReplaceWith(
            new XElement(docNs + "BkToCstmrDbtCdtNtfctn",
                groupHeader,
                list
            )
        );
    }
}