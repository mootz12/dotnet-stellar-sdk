// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct PeerAddress
//  {
//      union switch (IPAddrType type)
//      {
//      case IPv4:
//          opaque ipv4[4];
//      case IPv6:
//          opaque ipv6[16];
//      }
//      ip;
//      uint32 port;
//      uint32 numFailures;
//  };

//  ===========================================================================
public class PeerAddress  {
  public PeerAddress () {}
  public PeerAddressIp Ip {get; set;}
  public Uint32 Port {get; set;}
  public Uint32 NumFailures {get; set;}

  public static void Encode(XdrDataOutputStream stream, PeerAddress encodedPeerAddress) {
    PeerAddressIp.Encode(stream, encodedPeerAddress.Ip);
    Uint32.Encode(stream, encodedPeerAddress.Port);
    Uint32.Encode(stream, encodedPeerAddress.NumFailures);
  }
  public static PeerAddress Decode(XdrDataInputStream stream) {
    PeerAddress decodedPeerAddress = new PeerAddress();
    decodedPeerAddress.Ip = PeerAddressIp.Decode(stream);
    decodedPeerAddress.Port = Uint32.Decode(stream);
    decodedPeerAddress.NumFailures = Uint32.Decode(stream);
    return decodedPeerAddress;
  }

  public class PeerAddressIp {
    public PeerAddressIp () {}

    public IPAddrType Discriminant { get; set; } = new IPAddrType();

    public byte[] Ipv4 {get; set;}
    public byte[] Ipv6 {get; set;}
    public static void Encode(XdrDataOutputStream stream, PeerAddressIp encodedPeerAddressIp) {
    stream.WriteInt((int)encodedPeerAddressIp.Discriminant.InnerValue);
    switch (encodedPeerAddressIp.Discriminant.InnerValue) {
    case IPAddrType.IPAddrTypeEnum.IPv4:
    int ipv4size = encodedPeerAddressIp.Ipv4.Length;
    stream.Write(encodedPeerAddressIp.Ipv4, 0, ipv4size);
    break;
    case IPAddrType.IPAddrTypeEnum.IPv6:
    int ipv6size = encodedPeerAddressIp.Ipv6.Length;
    stream.Write(encodedPeerAddressIp.Ipv6, 0, ipv6size);
    break;
    }
    }
    public static PeerAddressIp Decode(XdrDataInputStream stream) {
    PeerAddressIp decodedPeerAddressIp = new PeerAddressIp();
    IPAddrType discriminant = IPAddrType.Decode(stream);
    decodedPeerAddressIp.Discriminant = discriminant;
    switch (decodedPeerAddressIp.Discriminant.InnerValue) {
    case IPAddrType.IPAddrTypeEnum.IPv4:
    int ipv4size = 4;
    decodedPeerAddressIp.Ipv4 = new byte[ipv4size];
    stream.Read(decodedPeerAddressIp.Ipv4,0,ipv4size);
    break;
    case IPAddrType.IPAddrTypeEnum.IPv6:
    int ipv6size = 16;
    decodedPeerAddressIp.Ipv6 = new byte[ipv6size];
    stream.Read(decodedPeerAddressIp.Ipv6,0,ipv6size);
    break;
    }
      return decodedPeerAddressIp;
    }

  }
}
}
