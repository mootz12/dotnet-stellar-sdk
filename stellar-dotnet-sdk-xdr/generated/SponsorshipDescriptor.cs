// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  typedef AccountID* SponsorshipDescriptor;

    //  ===========================================================================
    public class SponsorshipDescriptor
    {
        public AccountID InnerValue { get; set; } = default(AccountID);

        public SponsorshipDescriptor() { }

        public SponsorshipDescriptor(AccountID value)
        {
            InnerValue = value;
        }

        public static void Encode(XdrDataOutputStream stream, SponsorshipDescriptor encodedSponsorshipDescriptor)
        {
            if (encodedSponsorshipDescriptor.InnerValue != null)
            {
                stream.WriteInt(1);
                AccountID.Encode(stream, encodedSponsorshipDescriptor.InnerValue);
            }
            else
            {
                stream.WriteInt(0);
            }
        }
        public static SponsorshipDescriptor Decode(XdrDataInputStream stream)
        {
            SponsorshipDescriptor decodedSponsorshipDescriptor = new SponsorshipDescriptor();
            int SponsorshipDescriptorPresent = stream.ReadInt();
            if (SponsorshipDescriptorPresent != 0)
            {
                decodedSponsorshipDescriptor.InnerValue = AccountID.Decode(stream);
            }
            return decodedSponsorshipDescriptor;
        }
    }
}