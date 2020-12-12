﻿// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  enum ClaimPredicateType
    //  {
    //      CLAIM_PREDICATE_UNCONDITIONAL = 0,
    //      CLAIM_PREDICATE_AND = 1,
    //      CLAIM_PREDICATE_OR = 2,
    //      CLAIM_PREDICATE_NOT = 3,
    //      CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = 4,
    //      CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = 5
    //  };
    //  ===========================================================================
    public class ClaimPredicateType
    {
        public enum ClaimPredicateTypeEnum
        {
            CLAIM_PREDICATE_UNCONDITIONAL = 0,
            CLAIM_PREDICATE_AND = 1,
            CLAIM_PREDICATE_OR = 2,
            CLAIM_PREDICATE_NOT = 3,
            CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME = 4,
            CLAIM_PREDICATE_BEFORE_RELATIVE_TIME = 5,
        }
        public ClaimPredicateTypeEnum InnerValue { get; set; } = default(ClaimPredicateTypeEnum);
        public static ClaimPredicateType Create(ClaimPredicateTypeEnum v)
        {
            return new ClaimPredicateType
            {
                InnerValue = v
            };
        }
        public static ClaimPredicateType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_UNCONDITIONAL);
                case 1: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_AND);
                case 2: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_OR);
                case 3: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_NOT);
                case 4: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_ABSOLUTE_TIME);
                case 5: return Create(ClaimPredicateTypeEnum.CLAIM_PREDICATE_BEFORE_RELATIVE_TIME);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }
        public static void Encode(XdrDataOutputStream stream, ClaimPredicateType value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
