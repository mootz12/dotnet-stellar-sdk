﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  enum MemoType
    //  {
    //      MEMO_NONE = 0,
    //      MEMO_TEXT = 1,
    //      MEMO_ID = 2,
    //      MEMO_HASH = 3,
    //      MEMO_RETURN = 4
    //  };
    //  ===========================================================================
    public class MemoType
    {
        public enum MemoTypeEnum
        {
            MEMO_NONE = 0,
            MEMO_TEXT = 1,
            MEMO_ID = 2,
            MEMO_HASH = 3,
            MEMO_RETURN = 4,
        }
        public MemoTypeEnum InnerValue { get; set; } = default(MemoTypeEnum);
        public static MemoType Create(MemoTypeEnum v)
        {
            return new MemoType
            {
                InnerValue = v
            };
        }
        public static MemoType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(MemoTypeEnum.MEMO_NONE);
                case 1: return Create(MemoTypeEnum.MEMO_TEXT);
                case 2: return Create(MemoTypeEnum.MEMO_ID);
                case 3: return Create(MemoTypeEnum.MEMO_HASH);
                case 4: return Create(MemoTypeEnum.MEMO_RETURN);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }
        public static void Encode(XdrDataOutputStream stream, MemoType value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
