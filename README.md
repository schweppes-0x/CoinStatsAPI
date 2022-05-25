# API Wrapper for CoinStats
 A simple API wrapper for the v1 version of [coinstats.app](coinstats.app) written in .NET 4.8 framework. 
The documentation for the API can be found in the following [link](https://documenter.getpostman.com/view/5734027/RzZ6Hzr3)

# Components
These are the components that the wrapper(as of version 1.0.0) currently supports.

## Coins
Get coin list with global average prices.

| Parameter                 | Default value | Optional | Data type   |
|:--------------------------|:-------------:|---------:|-------------|
| `APIProperty.Skip`        |       0       |        ✅ | int         |
| `APIProperty.Limit`       |      20       |        ✅ | int         |
| `APIProperty.Currency`    |  `Fiat.EUR`   |        ✅ | Fiat (enum) |
 
---
```c#
List<Coin> defaultCoins = await CoinsAPI.GetCoinsAsync();
List<Coin> customCoins = await CoinsAPI.GetCoinsAsync(5, 0, Fiat.AMD);
```

## Price Charts
Get charts of prices for a specific coin within a specific period of time.


| Parameter            | Default value | Optional | Data type     |
|:---------------------|:-------------:|---------:|---------------|
| `APIProperty.Period` |   `Period.OneDay`   |        ❌ | Period (enum) |
| `APIProperty.CoinId`      |    bitcoin    |        ❌ | string        |

---
```c#
List<Chart> defaultCharts = await ChartsAPI.GetChartsAsync();
List<Chart> customCharts = await ChartsAPI.GetChartsAsync(Period.All, "ethereum");
```
 
---

## Exchange tickers
Get the currently supported exchanges.

| Parameter | Default value | Optional | Data type |
|:----------|:-------------:|---------:|-----------|
| -         |       -       |        - | -         |
 
---
```c#
List<string> exchanges = await ExchangesAPI.GetExchangesAsync();
```

## Markets
Get information about the current markets for a specific coin (_coinId_).


| Parameter       | Default value | Optional | Data type |
|:----------------|:-------------:|---------:|-----------|
| `APIProperty.CoinId` |      "bitcoin"      |        ❌ | string      |
 
---

```c#
List<MarketData> defaultMarkets = await MarketsAPI.GetMarketsAsync();
List<MarketData> market = await MarketsAPI.GetMarketsAsync("ethereum");
```

## Tickers
Get ticker prices for a specific pair and specific exchange.


| Parameter              |  Default value   | Optional | Data type       |
|:-----------------------|:----------------:|---------:|-----------------|
| `APIProperty.Exchange` | `Exchange.Yobit` |        ❌ | Exchange (enum) |
| `APIProperty.Pair`        |     "BTC-USD"      |        ❌ | string          |
 
---

```c#
List<TickerData> defaultTickers = await TickersAPI.GetTickersAsync();
List<TickerData> tickers = await TickersAPI.GetTickersAsync("Bittrex", "BTC-EUR");

```

## Fiat currencies
Get's a list of all the fiat currencies.


| Parameter | Default value | Optional | Data type |
|:----------|:-------------:|---------:|-----------|
| -         |       -       |        - | -         |


```c#
List<string> allFiats = await FiatsAPI.GetFiatsAsync();
```

## News
Gets latest crypto news from verified 40+ news sources


| Parameter            | Default value | Optional | Data type |
|:---------------------|:-------------:|---------:|-----------|
| `APIProperty.Skip`   |       0       |        ✅ | int       |
| `APIProperty.Limit`  |      20       |        ✅ | int       |
| `APIProperty.ToDate` | Current Time  |        ❌ | long      |
| `APIProperty.FromDate`      |      Yesterday      |        ❌ | long         |

---

```c#
List<NewsData> defaultNews = await NewsAPI.GetNewsAsync();
List<NewsData> customNews = await NewsAPI.GetNewsAsync(1653437530, 1653400000, 0, 5);
```

##Handpicked news
Get latest crypto news from verified 40+ news sources with filter

| Parameter            | Default value | Optional | Data type |
|:---------------------|:-------------:|---------:|-----------|
| `APIProperty.Skip`   |       0       |        ✅ | int       |
| `APIProperty.Limit`  |      20       |        ✅ | int       |

---

```c#
List<NewsData> defaultHandpicked = await HandPickedNewsAPI.GetHandPickedNews();
List<NewsData> customHandpicked = await HandPickedNewsAPI.GetHandPickedNews(1,3);
```

# Enumerations