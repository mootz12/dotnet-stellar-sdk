﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace stellar_dotnet_sdk.responses.effects
{
    public class LiquidityPoolRevokedEffectResponse : EffectResponse
    {
        public override int TypeId => 86;

        [JsonProperty(PropertyName = "liquidity_pool")]
        public LiquidityPoolEffectResponse LiquidityPool { get; set; }

        [JsonProperty(PropertyName = "reserves_revoked")]
        public LiquidityPoolClaimableAssetAmount[] ReservesRevoked { get; set; }
        
        [JsonProperty(PropertyName = "shares_revoked")]
        public string SharesRevoked { get; set; }


        public LiquidityPoolRevokedEffectResponse()
        {

        }

        public LiquidityPoolRevokedEffectResponse(LiquidityPoolEffectResponse liquidityPool, LiquidityPoolClaimableAssetAmount[] reservesRevoked, string sharesRevoked)
        {
            LiquidityPool = liquidityPool;
            ReservesRevoked = reservesRevoked;
            SharesRevoked = sharesRevoked;
        }
    }
}