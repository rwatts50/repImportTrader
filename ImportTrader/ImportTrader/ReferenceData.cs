using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImportTrader
{
    public class ReferenceData
    {

        public List<String> GetReferenceData(String dataSetName, String tableName)
        {   
            if (dataSetName.Contains("549026") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_549026_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_ExpertDonkeyV2_2_5ADay_1Trade_BreakEvenStopAt10");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Uses the 1M chart");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Places two pending trades at 6am, when one is triggered the other is cancelled.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 12 pips.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips.");
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips." );
                ACCOUNT_549026_EURUSD_DESCRIPTION.Add("Once the bot has made 10 pips the stop is set to the open price.");
                
                return ACCOUNT_549026_EURUSD_DESCRIPTION;
            }
            else if (dataSetName.Contains("549026") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_549026_DE30_DESCRIPTION = new List<String>();
                ACCOUNT_549026_DE30_DESCRIPTION.Add("This bot is based on the DonkeyV3 Strategy");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("BOT NAME: ExpertDonkeyV3");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("It works on the premise that over 50% of the time the first DE30 true movement of the day is in the same direction to where the index finishes the day");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Uses the 1M chart");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Places four pending (two per direction) trades on open, when two is triggered the other two are cancelled");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Buy Distance from open = 4 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Buy Take Profit = 6 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Buy Stop Loss = 10 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Buy Distance from open = 4 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Buy Take Profit = 35 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Buy Stop Loss = 10 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Sell Distance from open = 4 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Sell Take Profit = 6 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Small Sell Stop Loss =  10 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Sell Distance from open = 4 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Sell Take Profit = 35 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Large Sell Stop Loss = 10 pips");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("Once the price on a small or large order has hit the opening price (breakeven) the stop loss is adjusted to the open price");
                ACCOUNT_549026_DE30_DESCRIPTION.Add("A trailing stop of 15 points then follows the price of large orders");

                return ACCOUNT_549026_DE30_DESCRIPTION;
            }
            else if (dataSetName.Contains("607516") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_549556_DE30_DESCRIPTION = new List<String>();
                ACCOUNT_549556_DE30_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the DE30");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("BOT NAME: 5ADayTrade_TwoTrades_TrailStop");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("It works on the premise that over 50% of the time the first DE30 true movement of the day is in the same direction to where the index finishes the day");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Places four pending trades on open (two per direction), when two is triggered the other two are cancelled");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Buy Distance from open = 17 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Buy Take Profit = 6 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Buy Stop Loss = 11 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Buy Distance from open = 10 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Buy Take Profit = 35 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Buy Stop Loss = 11 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Sell Distance from open = 17 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Sell Take Profit = 6 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Small Sell Stop Loss =  10 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Sell Distance from open = 10 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Sell Take Profit = 35 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Large Sell Stop Loss = 10 pips");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("Once the price on a small or large order has hit the opening price (breakeven) the stop loss is adjusted to the open price");
                ACCOUNT_549556_DE30_DESCRIPTION.Add("A trailing stop of 15 points then follows the price of large orders");

                return ACCOUNT_549556_DE30_DESCRIPTION;
            }
            else if (dataSetName.Contains("607516") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_549556_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD5ADayTrade_TwoTrades_TrailStop");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day ");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Places four pending trades on open (two per direction), when two is triggered the other two are cancelled");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Buy Distance from open = 11 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Buy Take Profit = 6 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Buy Stop Loss = 12 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Buy Distance from open = 11 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Buy Take Profit = 39 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Buy Stop Loss = 12 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Sell Distance from open = 25 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Sell Take Profit = 6 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Small Sell Stop Loss =  11 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Sell Distance from open = 25 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Sell Take Profit = 39 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Large Sell Stop Loss = 12 pips");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("Once the price on a small or large order has hit the opening price (breakeven) the stop loss is adjusted to the open price");
                ACCOUNT_549556_EURUSD_DESCRIPTION.Add("A trailing stop of 15 points then follows the price of large orders");
                
                return ACCOUNT_549556_EURUSD_DESCRIPTION;
            }
            else if (dataSetName.Contains("607520") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_549563_DE30_DESCRIPTION = new List<String>();
                ACCOUNT_549563_DE30_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the DE30");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("BOT NAME: ExpertDonkeyV2_2_5ADay_1Trade_NoTrail");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("It works on the premise that over 50% of the time the first DE30 true movement of the day is in the same direction to where the index finishes the day");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Buy Distance from open = 10 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Buy Take Profit = 6 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Buy Stop Loss = 11 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Sell Distance from open = 10 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Sell Take Profit = 6 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Sell Stop Loss = 10 pips");
                ACCOUNT_549563_DE30_DESCRIPTION.Add("Once the price of an order has hit the opening price (breakeven) the stop loss is adjusted to the open price");

                return ACCOUNT_549563_DE30_DESCRIPTION;
            }
            else if (dataSetName.Contains("607520") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_549563_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_ExpertDonkeyV2_2_5ADay_1Trade_NoTrail");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 12 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips");
                ACCOUNT_549563_EURUSD_DESCRIPTION.Add("Once the price of an order has hit the opening price (breakeven) the stop loss is adjusted to the open price");

                return ACCOUNT_549563_EURUSD_DESCRIPTION;
            }
            else if (dataSetName.Contains("549572") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_549572_DE30_DESCRIPTION = new List<String>();
                ACCOUNT_549572_DE30_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the DE30");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("BOT NAME: 5ADayTrade_OneTrade_TrailStop");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("It works on the premise that over 50% of the time the first DE30 true movement of the day is in the same direction to where the index finishes the day");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Buy Distance from open = 17 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Buy Take Profit = 35 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Buy Stop Loss = 11 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Sell Distance from open = 10 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Sell Take Profit = 35 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Sell Stop Loss = 10 pips");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("Once the price of an order has hit the opening price (breakeven) the stop loss is adjusted to the open price");
                ACCOUNT_549572_DE30_DESCRIPTION.Add("A trailing stop of 15 points then follows the price");

                return ACCOUNT_549572_DE30_DESCRIPTION;
            }
            else if (dataSetName.Contains("549572") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_549572_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_5ADayTrade_OneTrade_TrailStop");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day ");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 1 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("Once the price of an order has hit the opening price (breakeven) the stop loss is adjusted to the open price");
                ACCOUNT_549572_EURUSD_DESCRIPTION.Add("A trailing stop of 15 points then follows the price");

                return ACCOUNT_549572_EURUSD_DESCRIPTION;
            }
            else if (dataSetName.Contains("549597") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_549597_DE30_DESCRIPTION = new List<String>();
                ACCOUNT_549597_DE30_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the DE30");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("BOT NAME: ExpertDonkeyV2_2_5ADay_1Trade_NoStop");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("It works on the premise that over 50% of the time the first DE30 true movement of the day is in the same direction to where the index finishes the day");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Buy Distance from open = 17 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Buy Take Profit = 6 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Buy Stop Loss = 11 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Sell Distance from open = 10 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Sell Take Profit = 6 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("Sell Stop Loss = 10 pips");
                ACCOUNT_549597_DE30_DESCRIPTION.Add("The stop is never altered");

                return ACCOUNT_549597_DE30_DESCRIPTION;
            }
            else if (dataSetName.Contains("549597") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_549597_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_ExpertDonkeyV2_2_5ADay_1Trade_NoStop");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day ");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Uses 1M chart");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 12 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips");
                ACCOUNT_549597_EURUSD_DESCRIPTION.Add("The stop is never altered");

                return ACCOUNT_549597_EURUSD_DESCRIPTION;
            }

            else if (dataSetName.Contains("865584") && tableName.Contains("eur"))
            {
                List<String> ACCOUNT_865584_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("LIVE ACCOUNT");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_ExpertDonkeyV2_2_5ADay_1Trade_BreakEvenStopAt10");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Uses the 1M chart");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Places two pending trades at 6am, when one is triggered the other is cancelled.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 12 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips.");
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Once the bot has made 10 pips the stop is set to the open price.");

                return ACCOUNT_865584_EURUSD_DESCRIPTION;
            }

            else if (dataSetName.Contains("865584") && tableName.Contains("de"))
            {
                List<String> ACCOUNT_865584_EURUSD_DESCRIPTION = new List<String>();
                ACCOUNT_865584_EURUSD_DESCRIPTION.Add("LIVE ACCOUNT");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("This bot is based on the 5 minutes a date trading strategy on the EURUSD");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("BOT NAME: EURUSD_ExpertDonkeyV2_2_5ADay_1Trade_NoStop");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("It works on the premise that over 50% of the time the first EUR_USD true movement of the day is in the opposite direction to where the pair finishes the day ");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Uses 1M chart");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Places two pending trades on open (one per direction), when one is triggered the other one are cancelled");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("BOT PARAMETERS: ");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Distance from open = 11 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Take Profit = 39 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Buy Stop Loss = 12 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Distance from open = 25 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Take Profit = 39 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("Sell Stop Loss = 12 pips");
                //ACCOUNT_865584_EURUSD_DESCRIPTION.Add("The stop is never altered");

                return ACCOUNT_865584_EURUSD_DESCRIPTION;
            }
            
            return new List<String>();

        }
    }  
}

