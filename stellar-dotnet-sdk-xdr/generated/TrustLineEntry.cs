﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  struct TrustLineEntry
    //  {
    //      AccountID accountID; // account this trustline belongs to
    //      Asset asset;         // type of asset (with issuer)
    //      int64 balance;       // how much of this asset the user has.
    //                           // Asset defines the unit for this;
    //  
    //      int64 limit;  // balance cannot be above this
    //      uint32 flags; // see TrustLineFlags
    //  
    //      // reserved for future use
    //      union switch (int v)
    //      {
    //      case 0:
    //          void;
    //      case 1:
    //          struct
    //          {
    //              Liabilities liabilities;
    //  
    //              union switch (int v)
    //              {
    //              case 0:
    //                  void;
    //              }
    //              ext;
    //          } v1;
    //      }
    //      ext;
    //  };
    //  ===========================================================================
    public class TrustLineEntry
    {
        public TrustLineEntry() { }
        public AccountID AccountID { get; set; }
        public Asset Asset { get; set; }
        public Int64 Balance { get; set; }
        public Int64 Limit { get; set; }
        public Uint32 Flags { get; set; }
        public TrustLineEntryExt Ext { get; set; }

        public static void Encode(XdrDataOutputStream stream, TrustLineEntry encodedTrustLineEntry)
        {
            AccountID.Encode(stream, encodedTrustLineEntry.AccountID);
            Asset.Encode(stream, encodedTrustLineEntry.Asset);
            Int64.Encode(stream, encodedTrustLineEntry.Balance);
            Int64.Encode(stream, encodedTrustLineEntry.Limit);
            Uint32.Encode(stream, encodedTrustLineEntry.Flags);
            TrustLineEntryExt.Encode(stream, encodedTrustLineEntry.Ext);
        }
        public static TrustLineEntry Decode(XdrDataInputStream stream)
        {
            TrustLineEntry decodedTrustLineEntry = new TrustLineEntry();
            decodedTrustLineEntry.AccountID = AccountID.Decode(stream);
            decodedTrustLineEntry.Asset = Asset.Decode(stream);
            decodedTrustLineEntry.Balance = Int64.Decode(stream);
            decodedTrustLineEntry.Limit = Int64.Decode(stream);
            decodedTrustLineEntry.Flags = Uint32.Decode(stream);
            decodedTrustLineEntry.Ext = TrustLineEntryExt.Decode(stream);
            return decodedTrustLineEntry;
        }

        public class TrustLineEntryExt
        {
            public TrustLineEntryExt() { }
            public int Discriminant { get; set; } = new int();
            public TrustLineEntryV1 V1 { get; set; }
            public static void Encode(XdrDataOutputStream stream, TrustLineEntryExt encodedTrustLineEntryExt)
            {
                stream.WriteInt((int)encodedTrustLineEntryExt.Discriminant);
                switch (encodedTrustLineEntryExt.Discriminant)
                {
                    case 0:
                        break;
                    case 1:
                        TrustLineEntryV1.Encode(stream, encodedTrustLineEntryExt.V1);
                        break;
                }
            }
            public static TrustLineEntryExt Decode(XdrDataInputStream stream)
            {
                TrustLineEntryExt decodedTrustLineEntryExt = new TrustLineEntryExt();
                int discriminant = stream.ReadInt();
                decodedTrustLineEntryExt.Discriminant = discriminant;
                switch (decodedTrustLineEntryExt.Discriminant)
                {
                    case 0:
                        break;
                    case 1:
                        decodedTrustLineEntryExt.V1 = TrustLineEntryV1.Decode(stream);
                        break;
                }
                return decodedTrustLineEntryExt;
            }

            public class TrustLineEntryV1
            {
                public TrustLineEntryV1() { }
                public Liabilities Liabilities { get; set; }
                public TrustLineEntryV1Ext Ext { get; set; }

                public static void Encode(XdrDataOutputStream stream, TrustLineEntryV1 encodedTrustLineEntryV1)
                {
                    Liabilities.Encode(stream, encodedTrustLineEntryV1.Liabilities);
                    TrustLineEntryV1Ext.Encode(stream, encodedTrustLineEntryV1.Ext);
                }
                public static TrustLineEntryV1 Decode(XdrDataInputStream stream)
                {
                    TrustLineEntryV1 decodedTrustLineEntryV1 = new TrustLineEntryV1();
                    decodedTrustLineEntryV1.Liabilities = Liabilities.Decode(stream);
                    decodedTrustLineEntryV1.Ext = TrustLineEntryV1Ext.Decode(stream);
                    return decodedTrustLineEntryV1;
                }

                public class TrustLineEntryV1Ext
                {
                    public TrustLineEntryV1Ext() { }
                    public int Discriminant { get; set; } = new int();
                    public static void Encode(XdrDataOutputStream stream, TrustLineEntryV1Ext encodedTrustLineEntryV1Ext)
                    {
                        stream.WriteInt((int)encodedTrustLineEntryV1Ext.Discriminant);
                        switch (encodedTrustLineEntryV1Ext.Discriminant)
                        {
                            case 0:
                                break;
                        }
                    }
                    public static TrustLineEntryV1Ext Decode(XdrDataInputStream stream)
                    {
                        TrustLineEntryV1Ext decodedTrustLineEntryV1Ext = new TrustLineEntryV1Ext();
                        int discriminant = stream.ReadInt();
                        decodedTrustLineEntryV1Ext.Discriminant = discriminant;
                        switch (decodedTrustLineEntryV1Ext.Discriminant)
                        {
                            case 0:
                                break;
                        }
                        return decodedTrustLineEntryV1Ext;
                    }

                }
            }
        }
    }
}
