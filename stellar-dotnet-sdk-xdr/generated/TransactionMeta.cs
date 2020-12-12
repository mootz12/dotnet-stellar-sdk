﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  union TransactionMeta switch (int v)
    //  {
    //  case 0:
    //      OperationMeta operations<>;
    //  case 1:
    //      TransactionMetaV1 v1;
    //  case 2:
    //      TransactionMetaV2 v2;
    //  };
    //  ===========================================================================
    public class TransactionMeta
    {
        public TransactionMeta() { }
        public int Discriminant { get; set; } = new int();
        public OperationMeta[] Operations { get; set; }
        public TransactionMetaV1 V1 { get; set; }
        public TransactionMetaV2 V2 { get; set; }
        public static void Encode(XdrDataOutputStream stream, TransactionMeta encodedTransactionMeta)
        {
            stream.WriteInt((int)encodedTransactionMeta.Discriminant);
            switch (encodedTransactionMeta.Discriminant)
            {
                case 0:
                    int operationssize = encodedTransactionMeta.Operations.Length;
                    stream.WriteInt(operationssize);
                    for (int i = 0; i < operationssize; i++)
                    {
                        OperationMeta.Encode(stream, encodedTransactionMeta.Operations[i]);
                    }
                    break;
                case 1:
                    TransactionMetaV1.Encode(stream, encodedTransactionMeta.V1);
                    break;
                case 2:
                    TransactionMetaV2.Encode(stream, encodedTransactionMeta.V2);
                    break;
            }
        }
        public static TransactionMeta Decode(XdrDataInputStream stream)
        {
            TransactionMeta decodedTransactionMeta = new TransactionMeta();
            int discriminant = stream.ReadInt();
            decodedTransactionMeta.Discriminant = discriminant;
            switch (decodedTransactionMeta.Discriminant)
            {
                case 0:
                    int operationssize = stream.ReadInt();
                    decodedTransactionMeta.Operations = new OperationMeta[operationssize];
                    for (int i = 0; i < operationssize; i++)
                    {
                        decodedTransactionMeta.Operations[i] = OperationMeta.Decode(stream);
                    }
                    break;
                case 1:
                    decodedTransactionMeta.V1 = TransactionMetaV1.Decode(stream);
                    break;
                case 2:
                    decodedTransactionMeta.V2 = TransactionMetaV2.Decode(stream);
                    break;
            }
            return decodedTransactionMeta;
        }
    }
}
