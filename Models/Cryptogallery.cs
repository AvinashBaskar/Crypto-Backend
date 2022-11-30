using System;
using System.Collections.Generic;

namespace dotnetcrypto.Models;

public partial class Cryptogallery
{
    public int Cryptoid { get; set; }

    public string? CryptoName { get; set; }

    public int? CryptoPrice { get; set; }

    public string? CryptoSymbol { get; set; }

    public int? CryptoPriceAfter24hrs { get; set; }

    public int? CryptoRank { get; set; }

    public int? CryptoSharePercentage { get; set; }

    public string? CryptoImage { get; set; }
}
