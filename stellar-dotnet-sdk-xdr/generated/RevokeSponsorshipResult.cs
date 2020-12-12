﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  union RevokeSponsorshipResult switch (RevokeSponsorshipResultCode code)
    //  {
    //  case REVOKE_SPONSORSHIP_SUCCESS:
    //      void;
    //  default:
    //      void;
    //  };
    //  ===========================================================================
    public class RevokeSponsorshipResult
    {
        public RevokeSponsorshipResult() { }
        public RevokeSponsorshipResultCode Discriminant { get; set; } = new RevokeSponsorshipResultCode();
        public static void Encode(XdrDataOutputStream stream, RevokeSponsorshipResult encodedRevokeSponsorshipResult)
        {
            stream.WriteInt((int)encodedRevokeSponsorshipResult.Discriminant.InnerValue);
            switch (encodedRevokeSponsorshipResult.Discriminant.InnerValue)
            {
                case RevokeSponsorshipResultCode.RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_SUCCESS:
                    break;
                default:
                    break;
            }
        }
        public static RevokeSponsorshipResult Decode(XdrDataInputStream stream)
        {
            RevokeSponsorshipResult decodedRevokeSponsorshipResult = new RevokeSponsorshipResult();
            RevokeSponsorshipResultCode discriminant = RevokeSponsorshipResultCode.Decode(stream);
            decodedRevokeSponsorshipResult.Discriminant = discriminant;
            switch (decodedRevokeSponsorshipResult.Discriminant.InnerValue)
            {
                case RevokeSponsorshipResultCode.RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_SUCCESS:
                    break;
                default:
                    break;
            }
            return decodedRevokeSponsorshipResult;
        }
    }
}
