// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union BumpSequenceResult switch (BumpSequenceResultCode code)
//  {
//  case BUMP_SEQUENCE_SUCCESS:
//      void;
//  default:
//      void;
//  };
//  ===========================================================================
    public class BumpSequenceResult
    {
        public BumpSequenceResult()
        {
        }

        public BumpSequenceResultCode Discriminant { get; set; } = new BumpSequenceResultCode();

        public static void Encode(XdrDataOutputStream stream, BumpSequenceResult encodedBumpSequenceResult)
        {
            stream.WriteInt((int) encodedBumpSequenceResult.Discriminant.InnerValue);
            switch (encodedBumpSequenceResult.Discriminant.InnerValue)
            {
                case BumpSequenceResultCode.BumpSequenceResultCodeEnum.BUMP_SEQUENCE_SUCCESS:
                    break;
                default:
                    break;
            }
        }

        public static BumpSequenceResult Decode(XdrDataInputStream stream)
        {
            BumpSequenceResult decodedBumpSequenceResult = new BumpSequenceResult();
            BumpSequenceResultCode discriminant = BumpSequenceResultCode.Decode(stream);
            decodedBumpSequenceResult.Discriminant = discriminant;
            switch (decodedBumpSequenceResult.Discriminant.InnerValue)
            {
                case BumpSequenceResultCode.BumpSequenceResultCodeEnum.BUMP_SEQUENCE_SUCCESS:
                    break;
                default:
                    break;
            }

            return decodedBumpSequenceResult;
        }
    }
}